import { Body } from './body.model';
export class Block {
    '$type': string;
    items: Block[];
    body: Body;
    id: string;
    type: string;
}
