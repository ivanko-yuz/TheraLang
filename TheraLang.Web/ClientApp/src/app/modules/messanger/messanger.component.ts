import { Component, OnInit, ViewChild, AfterViewChecked, ElementRef } from '@angular/core';
import { MessangerService } from 'src/app/core/http/messanger/messanger.service';
import { Chat } from 'src/app/shared/models/chat/chat';
import { Message } from 'src/app/shared/models/message/message';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr'
import { UserService } from 'src/app/core/auth/user.service';

@Component({
  selector: 'app-messanger',
  templateUrl: './messanger.component.html',
  styleUrls: ['./messanger.component.less']
})
export class MessangerComponent implements OnInit, AfterViewChecked {
  currentChat: Chat;
  messageText: string;
  currentUserId: string;
  hubConnection: HubConnection;
  @ViewChild('chatScroller', { static: false }) scroll: ElementRef;
  disableScrollDown = false

  constructor(private messangerService: MessangerService,
    private userService: UserService) {
  }

  ngOnInit() {
    this.currentUserId = this.userService.getCurrentUserId();
    this.hubConnection = new HubConnectionBuilder()
      .withUrl('/chatHub')
      .build();

    this.startConnection();
    this.listenChat();

    console.log('updated!');
  }

  ngAfterViewChecked(): void {
    if (this.currentChat) {
      this.scrollToBottom();
    }
  }

  scrollToBottom(): void {
    if (this.disableScrollDown) {
      return
    }
    try {
      this.scroll.nativeElement.scrollTop = this.scroll.nativeElement.scrollHeight;
    } catch (err) { }
  }

  onScroll() {
    let element = this.scroll.nativeElement
    let atBottom = element.scrollHeight - element.scrollTop === element.clientHeight
    if (this.disableScrollDown && atBottom) {
      this.disableScrollDown = false
    }

    if (element.scrollTop == 0) {
      console.log('*load data*');
    }

    else {
      this.disableScrollDown = true
    }

  }

  // start() {
  //   this.startConnection();
  //   this.listenChat();
  // }

  // stop() {
  //   this.hubConnection.stop();
  // }

  joinToChat(chatId: number) {
    this.hubConnection.invoke('joinRoom', chatId);
    console.log('joined to ', this.currentChat.id);
  }

  startConnection() {
    this.hubConnection
      .start()
      .then(function () {
        console.log('connection started!');
      })
      .catch(function (err) {
        console.log(err)
      })
  }

  listenChat() {
    this.hubConnection.on("RecieveMessage", (message: Message) => {
      this.currentChat.messages.push(message);
    });
  }

  action() {
  }

  // leaveChat() {
  //   this.hubConnection.invoke('leaveRoom', this.currentChat.id);
  // }

  updateChat(chatId: number) {
    this.messangerService.getChat(chatId).subscribe(async (data: Chat) => {
      this.currentChat = data;
      this.joinToChat(chatId);
    });
  }

  sendMessage() {
    const message: Message = {
      text: this.messageText,
      chatId: this.currentChat.id
    };

    this.messangerService.sendMessage(message).subscribe(async (msg: string) => {
      this.messageText = '';
      this.disableScrollDown = false;
      this.scrollToBottom();
    }, async (error) => {
      console.log(error);
    });
  }
}
