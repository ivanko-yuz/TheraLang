import { Component, OnInit, Input } from '@angular/core';
import { Block } from '../../models/block.model';
import { StringifyOptions } from 'querystring';

@Component({
  selector: 'app-gallery-block',
  templateUrl: './gallery-block.component.html',
  styleUrls: ['./gallery-block.component.less']
})
export class GalleryBlockComponent implements OnInit {

  @Input() block: Block;
  
  constructor() { }

  ngOnInit() {
  }

  cutLink(url: string): string {
    return url.substr(1);
  }

}
