import { HttpService } from './../project/http.service';
import { ResourceService } from './../resources-table/resource.service';
import { Component, OnInit, ViewEncapsulation, ViewChild, ElementRef } from '@angular/core';
import { Resource } from '../resources-table/resource';

@Component({
  selector: 'app-general-resources',
  templateUrl: './general-resources.component.html',
  styleUrls: ['./general-resources.component.less'],
  encapsulation: ViewEncapsulation.None,
})
export class GeneralResourcesComponent implements OnInit {
  sortedResourcesByCategory: Resource[][] = [];
  showTable = false;
  pageNumber: number;
  recordPerPage: number;
  constructor(private resourceService: ResourceService) { }
   async ngOnInit() {
    const allResources = await this.resourceService.getAllResources(this.pageNumber, this.recordPerPage);
    this.sortedResourcesByCategory = await this.resourceService.sortAllResourcesByCategories(allResources);
    this.showTable = true;
  }
}
