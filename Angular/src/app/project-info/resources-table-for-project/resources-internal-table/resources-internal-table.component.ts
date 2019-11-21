import { Resource } from '../../../general-resources/resource-models/resource';
import { Component, OnInit, Input, ViewChild, AfterViewInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material';
import { Constants } from 'src/app/general-resources/resource-models/resources-table-constants';

@Component({
  selector: 'app-resources-internal-table',
  templateUrl: './resources-internal-table.component.html',
  styleUrls: ['./resources-internal-table.component.less'],
})

export class ResourcesInternalTableComponent implements OnInit, AfterViewInit {
  @Input()dataSource: MatTableDataSource<Resource>;
  displayedColumns: string[] = ['id', 'name', 'date', 'description'];
  @Input()lengthDataArrForDataSource;
  pageSize: number;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;

  constructor() {  }

  ngOnInit() {
  }

  ngAfterViewInit() {
    this.pageSize = Constants.COLUMNS_PER_PAGE;
    this.dataSource.paginator = this.paginator;
  }
}

