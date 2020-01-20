import { Body } from "../body/body.model";
export class Block {
  "$type": string;
  items: Block[];
  body: Body;
  id: string;
  type: string;
}
