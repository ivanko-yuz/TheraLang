import { Component, OnInit, Input, ViewChild, ElementRef } from '@angular/core';
import { Resource } from '../resources-table/resource';
import { ResourceService } from './resource.service';
import { MatTableDataSource, MatTabChangeEvent } from '@angular/material';

@Component({
  selector: 'app-resources-table',
  templateUrl: './resources-table.component.html',
  styleUrls: ['./resources-table.component.less']
})
export class ResourcesTableComponent implements OnInit {
  @Input() sortedResourcesByCategory: Resource[][];
  @Input() lengthDataArrForDataSource: number;
  dataSource;
  constructor(private resourceService: ResourceService) { }
  ngOnInit() {
    // tslint:disable-next-line:forin
    for (const resCategoty in this.sortedResourcesByCategory) {
      this.selectResourcesArrayByCategotyName(resCategoty);
      return;
    }
  }

  convertMatTabChangeEventLabelToString(event: MatTabChangeEvent) {
    const category = event.tab.textLabel;
    this.selectResourcesArrayByCategotyName(category);
  }
  selectResourcesArrayByCategotyName(category: string) {
    this.setDataSourceToInternalResourcesTable(this.sortedResourcesByCategory[category]);
  }
  async setDataSourceToInternalResourcesTable(res: Resource[]) {
    this.dataSource = new MatTableDataSource(res);
  }
}
