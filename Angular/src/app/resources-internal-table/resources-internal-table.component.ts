import { Resource } from '../general-resources/resource-models/resource';
import { Component, OnInit, Input, ViewChild, AfterViewInit, Output } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material';

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
    setTimeout(() => {      
      this.dataSource.paginator = this.paginator;
    }, 5000);
    this.dataSource.paginator = this.paginator;
  }
}

