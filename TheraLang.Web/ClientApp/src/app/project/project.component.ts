import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service';
import { Project } from './project';
import { ProjectFormComponent } from '../project-form/project-form.component';
import { ProjectService } from './project.service';
import { DialogService } from '../shared/services/dialog.service';
import { MatDialog, MatDialogConfig } from '@angular/material';
import { NotificationService } from '../shared//services/notification.service';


@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.less'],
  providers: [ProjectService]
})
export class ProjectComponent implements OnInit {
  projects: Project[];

  constructor(
    private httpService: HttpService,
    private dialogService: DialogService,
    private service: ProjectService,
    private dialog: MatDialog,
    private notificationService: NotificationService
  ) { }


  ngOnInit() {
    this.httpService
      .getAllProjects()
      .subscribe((projects: Project[]) => (this.projects = projects));
  }

  onCreate() {
    this.service.initializeFormGroup();
    this.dialogService.openFormDialog(ProjectFormComponent);
  }

  onEdit(project) {
    this.service.populateForm(project);
    this.dialogService.openFormDialog(ProjectFormComponent);
  }

  onDelete(id) {
    this.dialogService.openConfirmDialog('Are you sure to delete this project?')
      .afterClosed().subscribe(res => {
        if (res) {
          this.httpService.deleteProject(id).subscribe(result => this.httpService.getAllProjects().subscribe((projects: Project[]) => this.projects = projects));
          this.notificationService.warn('Deleted successfully!');
        }
      });
  }
}
