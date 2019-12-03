import { Block } from '../../models/block.model';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-block',
  templateUrl: './block.component.html',
  styleUrls: ['./block.component.less']
})
export class BlockComponent {
  @Input() model: Block;
  imgUrl: string;

  constructor() { }

  cutLink(): string {
    return this.model.body.media.publicUrl.substr(1);
  }
}
