import { Component, OnInit, Input, Output, EventEmitter, ViewEncapsulation } from '@angular/core';
import { Resource } from '../../resource-models/resource';
import { ResourceService } from 'src/app/project-info/resources-table-for-project/resources-table/resource.service';
import { MatTabChangeEvent, MatTableDataSource, PageEvent } from '@angular/material';
import { ResourceCategoriesService } from 'src/app/project-info/resources-table-for-project/resources-table/resource-categories.service';
import { ResourceCategory } from '../../resource-models/resource-category';
import { Constants } from '../../resource-models/resources-table-constants';

@Component({
  selector: 'app-general-resources-table',
  templateUrl: './general-resources-table.component.html',
  styleUrls: ['./general-resources-table.component.less'],
  encapsulation: ViewEncapsulation.None
})
export class GeneralResourcesTableComponent implements OnInit {
 
  resourcesCategories: ResourceCategory[];
  showCategories: boolean = false;
  dataSource;
  constructor(public resourceService: ResourceService, 
    public resourceCategoriesService: ResourceCategoriesService
  ) { }

  async ngOnInit() {
    this.resourcesCategories = await this.resourceCategoriesService
      .getResourceCategories(Constants.WITH_ASSIGNED_RESOURCES)
    this.showCategories = true;
    // // tslint:disable-next-line:forin
    // for (const resCategoty in this.sortedResourcesByCategory) {
    //   this.selectResourcesArrayByCategotyName(resCategoty);
    //   return;      
  }
 
  
  
  // convertMatTabChangeEventLabelToString(event: MatTabChangeEvent) {
  //   const category = event.tab.textLabel;
  //   this.selectResourcesArrayByCategotyName(category);
    
  // }

  // selectResourcesArrayByCategotyName(category: string) {
  //   this.setDataSourceToInternalResourcesTable(this.sortedResourcesByCategory[category]);
  // }

  // async setDataSourceToInternalResourcesTable(res: Resource[]) {
  //   this.dataSource = new MatTableDataSource(res);
  // }

}
