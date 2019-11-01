import { Component, OnInit, Input } from '@angular/core';
import { Resource } from '../resources-table/resource';

@Component({
  selector: 'app-resources-table',
  templateUrl: './resources-table.component.html',
  styleUrls: ['./resources-table.component.less']
})
export class ResourcesTableComponent implements OnInit {

  constructor() { }
  @Input()resTablProjId: number;
  ngOnInit() {
    console.log('mainTable', this.resTablProjId);
  }
  // tslint:disable-next-line:use-lifecycle-interface
  // ngAfterViewInit() {
  //   // tslint:disable-next-line:only-arrow-functions
  //   this.resourcesData.forEach(function(value) {
  //     console.log(value);
  //   });}
  }
