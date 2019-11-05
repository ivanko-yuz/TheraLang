import { Component, OnInit, NgModule, Input, ViewChild } from '@angular/core';
import { Resource } from '../resources-table/resource';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material';

@Component({
  selector: 'app-resources-internal-table',
  templateUrl: './resources-internal-table.component.html',
  styleUrls: ['./resources-internal-table.component.less'],
})

export class ResourcesInternalTableComponent implements OnInit {
  displayedColumns: string[] = ['id', 'name', 'date', 'description'];
  @Input()dataSource: MatTableDataSource<Resource>;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;

  constructor() {  }

  ngOnInit() {
    this.dataSource.paginator = this.paginator;
  }
}

