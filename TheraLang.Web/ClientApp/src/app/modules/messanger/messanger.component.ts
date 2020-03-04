import { Component, OnInit } from '@angular/core';
import { MessangerService } from 'src/app/core/http/messanger/messanger.service';
import { Chat } from 'src/app/shared/models/chat/chat';
import { Message } from 'src/app/shared/models/message/message';
import { UserService } from 'src/app/core/auth/user.service';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr'

@Component({
  selector: 'app-messanger',
  templateUrl: './messanger.component.html',
  styleUrls: ['./messanger.component.less']
})
export class MessangerComponent implements OnInit {
  currentChat: Chat;
  messageText: string;
  currentUserId: string;
  hubConnection: HubConnection;

  constructor(private messangerService: MessangerService,
    private userService: UserService) {
  }

  ngOnInit() {
    this.currentUserId = this.userService.getCurrentUserId();
    this.startConnection();
  }

  startConnection() {
    this.hubConnection = new HubConnectionBuilder()
      .withUrl('/chatHub')
      .build();

    this.hubConnection.on("RecieveMessage", (message: Message) => {
      console.log('data: ', message)
    });

    this.hubConnection
      .start()
      .then(function () {
        this.hubConnection.invoke('joinRoom', this.currentChat.id);
      })
      .catch(function (err) {
        console.log(err)
      })
  }

  action() {
    console.log('curr user id ', this.currentUserId);
    console.log('curr chat id ', this.currentChat);
    console.log('hub conn ', this.hubConnection);
    //this.startConnection();
  }


  updateChat(chat: Chat) {
    this.currentChat = chat;
  }

  sendMessage() {
    const message: Message = {
      text: this.messageText,
      chatId: this.currentChat.id
    };

    this.messangerService.sendMessage(message).subscribe(async (msg: string) => {
      this.messageText = '';
    }, async (error) => {
      console.log(error);
    });
    console.log('message: ', message);
  }
}
