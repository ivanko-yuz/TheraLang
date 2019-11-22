import { Resource } from './../resources-table/resource';
import { Component, OnInit, Input, ViewChild, AfterViewInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material';

@Component({
  selector: 'app-resources-internal-table',
  templateUrl: './resources-internal-table.component.html',
  styleUrls: ['./resources-internal-table.component.less'],
})

export class ResourcesInternalTableComponent implements OnInit, AfterViewInit {
  @Input()dataSource: MatTableDataSource<Resource>;
  displayedColumns: string[] = ['id', 'name', 'date', 'description'];  
  @Input()lengthDataArrForDataSource;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;

  constructor() {  }

  ngOnInit() {
     
  }
  ngAfterViewInit(){
    console.log(this.lengthDataArrForDataSource,  "1");   
    setTimeout(() => {
      console.log(this.lengthDataArrForDataSource,  "1");   
      this.dataSource.paginator = this.paginator;
    }, 5000);
    this.dataSource.paginator = this.paginator;
  }
}
