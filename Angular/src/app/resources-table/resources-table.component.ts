import { Component, OnInit, Input } from '@angular/core';
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
  dataSource: MatTableDataSource<Resource> = new MatTableDataSource<Resource>();
  constructor(private resourceService: ResourceService) { }
  ngOnInit() {
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
  setDataSourceToInternalResourcesTable(res: Resource[]) {
    this.dataSource = new MatTableDataSource(res);
  }
}
