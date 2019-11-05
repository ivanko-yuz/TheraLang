import { ResourceService } from './../resources-table/resource.service';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { Resource } from '../resources-table/resource';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-general-resources',
  templateUrl: './general-resources.component.html',
  styleUrls: ['./general-resources.component.less'],
  encapsulation: ViewEncapsulation.None,
})
export class GeneralResourcesComponent implements OnInit {

  subscribe: Subscription;
  resources: Resource[][] = [];
  constructor(private resourceService: ResourceService) { }
   async ngOnInit() {
    const resources = await this.resourceService.getAllResourcesByProjId(1);
    this.resources = this.resourceService.sort(resources);
  }
}
