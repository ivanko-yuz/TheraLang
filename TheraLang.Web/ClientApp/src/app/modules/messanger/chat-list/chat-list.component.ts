import { Component, OnInit, Output, EventEmitter } from "@angular/core";
import { MessangerService } from "src/app/core/http/messanger/messanger.service";
import { Chat } from "src/app/shared/models/chat/chat";

@Component({
  selector: "app-chat-list",
  templateUrl: "./chat-list.component.html",
  styleUrls: ["./chat-list.component.less"],
})
export class ChatListComponent implements OnInit {
  chats: Chat[];
  @Output() onChatChange: EventEmitter<number> = new EventEmitter<number>();
  @Output() onLoad: EventEmitter<boolean> = new EventEmitter<boolean>();

  constructor(private messangerService: MessangerService) {
    this.chats = [];
  }

  ngOnInit() {
    this.messangerService.getAllChats().subscribe(async (data: Chat[]) => {
      this.chats = data;
      this.onLoad.emit(data.length > 0);
    }, error => {
      console.log(error);
    });
  }

  changeChat(id: number) {
    this.onChatChange.emit(id);
  }
}
