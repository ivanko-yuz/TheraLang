import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { chatUrl } from 'src/app/configs/api-endpoint.constants';
import { Message } from 'src/app/shared/models/message/message';

@Injectable({
  providedIn: 'root'
})
export class MessangerService {

  private url = chatUrl;

  constructor(private http: HttpClient) { }

  getAllChats() {
    return this.http.get(this.url);
  }

  getChat(id: number) {
    return this.http.get(`${this.url}/${id}`);
  }

  sendMessage(message: Message) {
    return this.http.post(`${this.url}/message`, message);
  }
}
