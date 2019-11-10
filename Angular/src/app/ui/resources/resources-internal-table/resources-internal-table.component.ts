import { Resource } from '../resources-table/resource';
import { Component, OnInit, Input, ViewChild, AfterViewInit, SimpleChanges } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material';

@Component({
  selector: 'app-resources-internal-table',
  templateUrl: './resources-internal-table.component.html',
  styleUrls: ['./resources-internal-table.component.less'],
})

export class ResourcesInternalTableComponent implements OnInit, AfterViewInit {
  _dataSource: MatTableDataSource<Resource>;
  @Input() set dataSource(value: MatTableDataSource<Resource>){
    this._dataSource = value;
    this.dataSource.paginator = this.paginator;
  }
  get dataSource(): MatTableDataSource<Resource>{
    return this._dataSource;
  }

  displayedColumns: string[] = ['id', 'name', 'date', 'description'];  
  @Input()lengthDataArrForDataSource;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;

  constructor() {  }

  ngOnInit() {
     
  }
  ngAfterViewInit(){
    
  }
}

