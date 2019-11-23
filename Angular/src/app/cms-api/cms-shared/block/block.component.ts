import { Block } from './../../models/block.model';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-block',
  templateUrl: './block.component.html',
  styleUrls: ['./block.component.less']
})
export class BlockComponent implements OnInit {
  @Input() model: Block;
  imgUrl: string;
  constructor() { }
  
  ngOnInit() {   
  }

  cutLink(): string {
    return this.model.body.media.publicUrl.substr(1);
  }
}
