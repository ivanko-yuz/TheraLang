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
  constructor(private resourceService: ResourceService) { }
   async ngOnInit() {
    const allResources = await this.resourceService.getAllResourcesByProjId(null);
    this.sortedResourcesByCategory = this.resourceService.sortAllResourcesByCategories(allResources);
  }
}
