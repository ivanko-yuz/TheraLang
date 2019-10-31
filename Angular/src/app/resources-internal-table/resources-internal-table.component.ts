import { Component, OnInit, NgModule } from '@angular/core';
import { ProjectInfoComponent } from '../project-info/project-info.component';
import { Resource } from '../resources-table/resource';
import {MatTableModule} from '@angular/material/table';



@Component({
  selector: 'app-resources-internal-table',
  templateUrl: './resources-internal-table.component.html',
  styleUrls: ['./resources-internal-table.component.less'],
  providers: [MatTableModule]
})

export class ResourcesInternalTableComponent implements OnInit {

  constructor( private resources: ProjectInfoComponent) { }
  rescs: Resource = new Resource(1, 'qwert', new Date(2018, 0O5, 0O5, 17, 23, 42, 11), 2);
  ngOnInit() {
  }

}
