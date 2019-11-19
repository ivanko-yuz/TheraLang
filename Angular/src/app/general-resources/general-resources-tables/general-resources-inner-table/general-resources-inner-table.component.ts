import { Component, OnInit, ViewChild, Input, Output, EventEmitter, OnChanges } from '@angular/core';
import { MatTableDataSource, MatPaginator, PageEvent } from '@angular/material';
import { Resource } from 'src/app/general-resources/resource-models/resource';
import { ResourceService } from 'src/app/resources-table/resource.service';

@Component({
  selector: 'app-general-resources-inner-table',
  templateUrl: './general-resources-inner-table.component.html',
  styleUrls: ['./general-resources-inner-table.component.less']
})
export class GeneralResourcesInnerTableComponent implements OnInit, OnChanges {
  @Input() countAllResources: number;

  // tslint:disable-next-line:variable-name
  _dataSource: MatTableDataSource<Resource>;
  @Input() set  dataSource(value: MatTableDataSource<Resource>) {
    this._dataSource = value;
    this.dataSource.paginator = this.paginator;
    this.dataSource.paginator.length = this.countAllResources;   
  }
  get dataSource(): MatTableDataSource<Resource> {
    return this._dataSource;  
  }

  displayedColumns: string[] = ['id', 'name', 'date', 'description'];
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @Output() pageChangedEvent:EventEmitter<PageEvent> = new  EventEmitter<PageEvent>();

  constructor(public resourceService: ResourceService) { }

  async ngOnInit() {
    // this.countAllResources = await this.resourceService.getCountAllResources(1);
    
  }

  async ngOnChanges() {
   
  }
  pageChanged(event: PageEvent) {
    this.pageChangedEvent.emit(event);
  }
}
