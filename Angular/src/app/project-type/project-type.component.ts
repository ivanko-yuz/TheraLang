import { Component, OnInit } from '@angular/core';
import { ProjectTypeService } from './project-type.service';
import { ProjectType } from './project-type.model';

@Component({
  selector: 'app-project-type',
  templateUrl: './project-type.component.html',
  styleUrls: ['./project-type.component.less']
})
export class ProjectTypeComponent implements OnInit {
  projectTypes: ProjectType[];
  constructor(private projectTypeService: ProjectTypeService) { }
  displayedColumns: string[] = ['name'];
  //dataSource = array;

  async ngOnInit() {
   this.projectTypes = await this.projectTypeService.getAllProjectTypes();
  }

}
