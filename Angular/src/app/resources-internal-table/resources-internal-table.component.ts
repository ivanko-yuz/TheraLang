import { Component, OnInit, NgModule, Input, ViewChild } from '@angular/core';
import { ProjectInfoComponent } from '../project-info/project-info.component';
import { Resource } from '../resources-table/resource';
import { MatTableModule, MatTableDataSource } from '@angular/material/table';
import { DataSource } from '@angular/cdk/table';
import { BehaviorSubject, Observable } from 'rxjs';
import { HttpService } from '../project/http.service';
import { isNullOrUndefined } from 'util';
import { HttpClient } from '@angular/common/http';
import { ResourceCategory } from '../resources-table/resourceCategory';
import { ResourceService } from '../resources-table/resources.service';
import { MatPaginator, MatSort } from '@angular/material';



@Component({
  selector: 'app-resources-internal-table',
  templateUrl: './resources-internal-table.component.html',
  styleUrls: ['./resources-internal-table.component.less'],

})

export class ResourcesInternalTableComponent implements OnInit {

  resourceCategories: ResourceCategory[];
  @Input() resInternalTablProjId: number;
  idCount: number = 1;
  
  displayedColumns: string[] = ['id', 'name', 'date', 'description'];
  dataSource: MatTableDataSource<Resource>;
 

  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  constructor(private http: HttpService, private resourcesService: ResourceService) {  }

  ngOnInit() {this.dataSource = new MatTableDataSource(this.resourcesService.allProjectResources);
    this.dataSource.paginator = this.paginator;
    
  }
}

