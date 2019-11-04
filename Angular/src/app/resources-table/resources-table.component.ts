import { ResourceCategory } from './resourceCategory';
import { HttpService } from './../project/http.service';
import { Component, OnInit, Input } from '@angular/core';
import { Resource } from '../resources-table/resource';
import { ResourceService } from './resource.service';

@Component({
  selector: 'app-resources-table',
  templateUrl: './resources-table.component.html',
  styleUrls: ['./resources-table.component.less']
})
export class ResourcesTableComponent implements OnInit {
  @Input()resTablProjId: number;
  constructor(private resourceService: ResourceService) { }
    ngOnInit() {
  }
}
