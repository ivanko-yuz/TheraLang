import {Component, Input, OnInit, ViewChild} from '@angular/core';
import {ToolbarItem} from './toolbar-item';
import {MatMenu} from '@angular/material';

@Component({
  selector: 'app-toolbar-item',
  templateUrl: './toolbar-item.component.html',
  styleUrls: ['./toolbar-item.component.less']
})
export class ToolbarItemComponent implements OnInit {

  toolbarItemParam: ToolbarItem;
  @Input() set toolbarItem(value: ToolbarItem) {
    this.toolbarItemParam = value;
  }
  get toolbarItem(): ToolbarItem {
    return this.toolbarItemParam;
  }

  @ViewChild('menu', {static: false}) menu: any;

  constructor() { }

  ngOnInit() {
  }

  isFinalMenu(): boolean {
    return !this.needSubMenus();
  }

  needSubMenus(): boolean {
    return this.toolbarItem.subItems.length > 0;
  }

}
