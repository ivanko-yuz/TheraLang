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
  @Input() resources: Resource[][];
  dataSource: MatTableDataSource<Resource>;
  constructor(private resourceService: ResourceService) { }
  ngOnInit() {
    for (const ress in this.resources) {
      this.changePageByName(ress);
      return;
    } 
  }

  changePage(event: MatTabChangeEvent) {
    const category = event.tab.textLabel;
    this.changePageByName(category);
  }
  changePageByName(category: string) {
    this.changeTabDataSource(this.resources[category]);
  }
  changeTabDataSource(res: Resource[]) {
    this.dataSource = new MatTableDataSource(res);
  }
}
