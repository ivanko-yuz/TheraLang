import { HttpService } from './../project/http.service';
import { ResourceService } from './../resources-table/resource.service';
import { Component, OnInit, ViewEncapsulation, ViewChild, ElementRef, OnChanges } from '@angular/core';
import { Resource } from './resource-models/resource';
import { PageEvent } from '@angular/material';
import { Constants } from './resource-models/resources-table-constants';

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
  allResources: Resource[];  
  constructor(private resourceService: ResourceService) { }

  async ngOnInit() {    
    const allResources = await this.resourceService.getAllResources(1, Constants.COLUMNS_PER_PAGE);
    this.sortedResourcesByCategory = await this.resourceService.sortAllResourcesByCategories(allResources);
    this.showTable = true;
  }

  async innerTableEvent(event: PageEvent) {
    this.pageNumber = event.pageIndex + 1;
    this.recordPerPage = event.pageSize;
    console.log(this.pageNumber);
    
    this.allResources = await this.resourceService.getAllResources(this.pageNumber, this.recordPerPage);
    this.sortedResourcesByCategory = await this.resourceService.sortAllResourcesByCategories(this.allResources);
  }
}
