import { Component, OnInit, Output, EventEmitter  } from '@angular/core';
import { MessangerService } from 'src/app/core/http/messanger/messanger.service';
import { Chat } from 'src/app/shared/models/chat/chat';

@Component({
  selector: 'app-chat-list',
  templateUrl: './chat-list.component.html',
  styleUrls: ['./chat-list.component.less']
})
export class ChatListComponent implements OnInit {
  chats: Chat[];
  chat: Chat;
  @Output() onChatChange: EventEmitter<Chat> = new EventEmitter<Chat>();

  constructor(private messangerService: MessangerService) { }

  ngOnInit() {
    this.messangerService.getAllChats().subscribe(async (data: Chat[]) => this.chats = data);
    if (this.chats) {
      this.changeChat(this.chats[0].id);
    }
  }

  changeChat(id: number) {
    this.messangerService.getChat(id).subscribe(async (data: Chat) => this.chat = data)
    this.onChatChange.emit(this.chat);
  }
}
