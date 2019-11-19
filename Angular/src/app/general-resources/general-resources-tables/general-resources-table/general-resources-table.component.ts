import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Resource } from '../../resource-models/resource';
import { ResourceService } from 'src/app/resources-table/resource.service';
import { MatTabChangeEvent, MatTableDataSource, PageEvent } from '@angular/material';

@Component({
  selector: 'app-general-resources-table',
  templateUrl: './general-resources-table.component.html',
  styleUrls: ['./general-resources-table.component.less']
})
export class GeneralResourcesTableComponent implements OnInit {
  @Input() sortedResourcesByCategory: Resource[][];
  @Output() innerPageChangedEvent:EventEmitter<PageEvent> = new  EventEmitter<PageEvent>();
  dataSource;
  constructor(public resourceService: ResourceService) { }
  async ngOnInit() {
    // tslint:disable-next-line:forin
    for (const resCategoty in this.sortedResourcesByCategory) {
      this.selectResourcesArrayByCategotyName(resCategoty);
      return;      
    }
  }

  innerTableEvent(event: PageEvent){
    this.innerPageChangedEvent.emit(event);
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
