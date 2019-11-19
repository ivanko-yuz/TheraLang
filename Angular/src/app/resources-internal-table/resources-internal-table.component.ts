import { Resource } from './../resources-table/resource';
import { Component, OnInit, Input, ViewChild, AfterViewInit, Output } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material';

@Component({
  selector: 'app-resources-internal-table',
  templateUrl: './resources-internal-table.component.html',
  styleUrls: ['./resources-internal-table.component.less'],
})

export class ResourcesInternalTableComponent implements OnInit, AfterViewInit {
  @Input() lengthDataArrForDataSource: number;
  pageNumber: number;
  itemsPerPage: number;
  // tslint:disable-next-line:variable-name
  _dataSource: MatTableDataSource<Resource>;
  @Input() set dataSource(value: MatTableDataSource<Resource>) {
    this._dataSource = value;
    this.dataSource.paginator = this.paginator;
    this.dataSource.paginator.length = this.lengthDataArrForDataSource;
  }

  get dataSource(): MatTableDataSource<Resource> {
    return this._dataSource;
  }

  displayedColumns: string[] = ['id', 'name', 'date', 'description'];
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;

  constructor() {  }

  ngOnInit() {
  }
  ngAfterViewInit() {
  }
  pageChanged(event: PageEvent) {
    this.pageNumber = event.pageIndex;
    this.itemsPerPage = event.pageSize;
  }
}

