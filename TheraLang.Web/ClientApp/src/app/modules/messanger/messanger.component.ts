import { Component, OnInit, ViewChild, AfterViewChecked, ElementRef, OnDestroy } from '@angular/core';
import { MessangerService } from 'src/app/core/http/messanger/messanger.service';
import { Chat } from 'src/app/shared/models/chat/chat';
import { Message } from 'src/app/shared/models/message/message';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr'
import { UserService } from 'src/app/core/auth/user.service';
import { MessageParameters } from 'src/app/shared/models/chat/message-parameters';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-messanger',
  templateUrl: './messanger.component.html',
  styleUrls: ['./messanger.component.less']
})
export class MessangerComponent implements OnInit, AfterViewChecked, OnDestroy {
  currentChat: Chat;
  currentUserId: string;
  hubConnection: HubConnection;
  messages: Message[];
  disableScrollDown = false;
  pageNumber: number;
  form: FormGroup;
  chatsExist: boolean;
  @ViewChild('chatScroller', { static: false }) scroll: ElementRef;

  constructor(private messangerService: MessangerService,
    private userService: UserService) {
  }

  ngOnInit() {
    this.form = new FormGroup({
      messageText: new FormControl(null, [Validators.required, Validators.maxLength(256)]),
    });
    this.pageNumber = 1;
    this.messages = [];
    this.currentUserId = this.userService.getCurrentUserId();
    this.hubConnection = new HubConnectionBuilder()
      .withUrl(`/chatHub`)
      .build();

    this.connect();
    this.listenChat();
  }

  ngAfterViewChecked(): void {
    if (this.currentChat) {
      this.scrollToBottom();
    }
  }

  ngOnDestroy(): void {
    if (this.hubConnection.state == 1) {
      this.leaveChat();
    }
  }

  loadMessages() {
    var params: MessageParameters = {
      chatId: this.currentChat.id,
      pageNumber: this.pageNumber,
      pageSize: 15
    };

    this.messangerService.getMessages(params).subscribe(async (data: Message[]) => {
      this.messages.unshift(...data.reverse());
      this.pageNumber++;
    });
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
    let element = this.scroll.nativeElement;
    let atBottom = element.scrollHeight - element.scrollTop === element.clientHeight;
    if (this.disableScrollDown && atBottom) {
      this.disableScrollDown = false;
    }

    if (element.scrollTop == 0 && this.pageNumber <= this.currentChat.pagesCount) {
      this.loadMessages();
      element.scrollTop = 35;
    }

    else {
      this.disableScrollDown = true;
    }
  }

  joinToChat(chatId: number) {
    this.hubConnection.invoke('joinRoom', chatId);
  }

  connect() {
    this.hubConnection
      .start()
      .catch(function (err) {
        console.log(err)
      })
  }

  listenChat() {
    this.hubConnection.on("RecieveMessage", (message: Message) => {
      this.messages.push(message);
      this.disableScrollDown = false;
      this.scrollToBottom();
    });
  }

  leaveChat() {
    if (this.currentChat) {
      this.hubConnection.invoke('leaveRoom', this.currentChat.id);
    }
  }

  checkIfchats(chatsExist: boolean) {
    this.chatsExist = chatsExist;
  }

  updateChat(chatId: number) {
    this.leaveChat();
    this.messangerService.getChat(chatId).subscribe(async (data: Chat) => {
      this.reset();
      this.currentChat = data;
      this.joinToChat(chatId);
      this.loadMessages();
    });
  }

  reset() {
    this.messages = [];
    this.pageNumber = 1;
  }

  sendMessage() {
    const message: Message = {
      text: this.form.value.messageText,
      chatId: this.currentChat.id
    };

    this.messangerService.sendMessage(message).subscribe(async (msg: string) => {
      this.form.reset();
      this.disableScrollDown = false;
      this.scrollToBottom();
    }, async (error) => {
      console.log(error);
    });
  }
}
