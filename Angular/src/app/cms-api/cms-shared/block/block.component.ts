import { Block } from './../../when-get-page-by-slug/block.model';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-block',
  templateUrl: './block.component.html',
  styleUrls: ['./block.component.less']
})
export class BlockComponent implements OnInit {
  @Input() model: Block;
  constructor() { }
  
  ngOnInit() {
    // this.model.body.value
  }

}
