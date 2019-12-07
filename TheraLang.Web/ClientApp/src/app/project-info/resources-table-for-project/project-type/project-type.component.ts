import { Component, OnInit } from '@angular/core';
import { ProjectTypeService } from './project-type.service';
import { ProjectType } from './project-type.model';
import { NotificationService } from 'src/app/shared/services/notification.service';
import { DialogService } from 'src/app/shared/services/dialog.service';
import { ProjectTypeHttp } from 'src/app/project-type/ProjectTypeHttp.service';

@Component({
  selector: 'app-project-type',
  templateUrl: './project-type.component.html',
  styleUrls: ['./project-type.component.less']
})

export class ProjectTypeComponent implements OnInit {
  projectTypes: ProjectType[];
  constructor(private projectTypeService: ProjectTypeService,
    private dialogService: DialogService,
    notificationService: NotificationService,
    http: ProjectTypeHttp) { }
  displayedColumns: string[] = ['typeName', 'actions'];

  async ngOnInit() {
    // debugger
    this.projectTypes = await this.projectTypeService.getAllProjectTypes();
  }

  // onDelete(id) {
  //   this.dialogService.openConfirmDialog('Are you sure to delete this project?')
  //     .afterClosed().subscribe(res => {
  //       if (res) {
  //         this.http.deleteProject(id).subscribe(result => this.http.getAllProjects().subscribe((projects: Project[]) => this.projects = projects));
  //         this.notificationService.warn('Deleted successfully!');
  //       }
  //     });
  // }

}
