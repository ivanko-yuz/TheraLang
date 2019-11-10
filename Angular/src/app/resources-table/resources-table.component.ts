import { Component, OnInit, Input, OnChanges } from '@angular/core';
import { Resource } from '../resources-table/resource';
import { ResourceService } from './resource.service';
import { MatTableDataSource, MatTabChangeEvent } from '@angular/material';

@Component({
  selector: 'app-resources-table',
  templateUrl: './resources-table.component.html',
  styleUrls: ['./resources-table.component.less']
})
export class ResourcesTableComponent implements OnInit, OnChanges {
  ngOnChanges() {
   
  }
  @Input() sortedResourcesByCategory: Resource[][];
  lengthDataArrForDataSource: number;
  dataSource;
  constructor(private resourceService: ResourceService) { }
  ngOnInit() {
  }

  convertMatTabChangeEventLabelToString(event: MatTabChangeEvent) {
    const category = event.tab.textLabel;
    this.selectResourcesArrayByCategotyName(category);
  }
  selectResourcesArrayByCategotyName(category: string) {
    this.setDataSourceToInternalResourcesTable(this.sortedResourcesByCategory[category]);
  }
  setDataSourceToInternalResourcesTable(res: Resource[]) {
    this.lengthDataArrForDataSource = res.length;
    this.dataSource = new MatTableDataSource(res);
  }
}
