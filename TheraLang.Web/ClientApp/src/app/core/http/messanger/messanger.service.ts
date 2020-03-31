import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { chatUrl } from "src/app/configs/api-endpoint.constants";
import { Message } from "src/app/shared/models/message/message";
import { Observable } from "rxjs";
import { Chat } from "src/app/shared/models/chat/chat";
import { PaginationParams } from "src/app/shared/models/pagination-params/pagination-params";

@Injectable({
  providedIn: "root",
})
export class MessangerService {

  private url = chatUrl;

  constructor(private http: HttpClient) { }

  getAllChats(): Observable<Chat[]> {
    return this.http.get<Chat[]>(this.url);
  }

  getChat(id: number): Observable<Chat> {
    return this.http.get<Chat>(`${this.url}/${id}`);
  }

  getMessages(chatId: number, paginationParams: PaginationParams): Observable<Message[]> {
    return this.http.get<Message[]>(`${this.url}/${chatId}/messages?pageNumber=${paginationParams.pageNumber}&pageSize=${paginationParams.pageSize}`);
  }

  sendMessage(message: Message) {
    return this.http.post(`${this.url}/message`, message);
  }
}
