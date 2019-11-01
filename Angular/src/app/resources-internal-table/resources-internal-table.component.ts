import { Component, OnInit, NgModule, Input } from '@angular/core';
import { ProjectInfoComponent } from '../project-info/project-info.component';
import { Resource } from '../resources-table/resource';
import {MatTableModule} from '@angular/material/table';
import { DataSource } from '@angular/cdk/table';
import { BehaviorSubject, Observable } from 'rxjs';
import { HttpService } from '../project/http.service';
import { isNullOrUndefined } from 'util';
import { HttpClient } from '@angular/common/http';



@Component({
  selector: 'app-resources-internal-table',
  templateUrl: './resources-internal-table.component.html',
  styleUrls: ['./resources-internal-table.component.less'],
  providers: [MatTableModule, HttpService]
})

export class ResourcesInternalTableComponent implements OnInit {

  constructor( private http: HttpService) { }

  resourcesInnerTableData: Resource[];
  @Input()resInternalTablProjId: number;

  displayedColumns: string[] = ['id', 'name', ];
  dataSource = this.resourcesInnerTableData;
  ngOnInit() {
        console.log(this.resInternalTablProjId);

        this.http.getAllResourcesById(this.resInternalTablProjId).subscribe((data: Resource[]) => this.resourcesInnerTableData = data);

        // this.http.get<Resource[]>('https://localhost:44353/api/project/1/resources').
        // subscribe((data: Resource[]) => this.resourcesInnerTableData = data);

        console.log('interalTable');
        console.log(this.resourcesInnerTableData.length);
      }

  }


// ngAfterVievInit() {
  // tslint:disable-next-line:only-arrow-functions



// export class ExampleDataSource extends DataSource<PeriodicElement> {
//   /** Stream of data that is provided to the table. */
//   data = new BehaviorSubject<PeriodicElement[]>(resourcesData);

//   /** Connect function called by the table to retrieve one stream containing the data to render. */
//   connect(): Observable<PeriodicElement[]> {
//     return this.data;
//   }

