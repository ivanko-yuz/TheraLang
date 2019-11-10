import { Resource } from './../resources-table/resource';
import { Component, OnInit, Input, ViewChild, AfterViewInit, OnChanges, SimpleChanges } from '@angular/core';
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
  }
  ngOnChanges(changes: SimpleChanges){
    if(changes['dataSource']) {
      this.dataSource.paginator = this.paginator;
    }
  }
}

