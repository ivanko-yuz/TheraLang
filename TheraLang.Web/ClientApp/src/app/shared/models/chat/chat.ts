import { Message } from "../message/message";

export class Chat {
  id?: number;
  name: string;
  type: number;
  messages?: Message[];
  pagesCount: number;
}
