import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { Project } from './project';
import { MatDialogConfig } from '@angular/material';
import { CreateProjectComponent } from '../create-project/create-project.component';
import { ProjectService } from './shared/project.service';
let ProjectComponent = class ProjectComponent {
    constructor(httpService, dialog, service) {
        this.httpService = httpService;
        this.dialog = dialog;
        this.service = service;
        this.project = new Project(1, 'abcde', 'qwerty', 'awdawed');
    }
    ngOnInit() {
        this.httpService.getAllProjects().subscribe((data) => this.projects = data);
    }
    onCreate() {
        const dialogConfig = new MatDialogConfig();
        dialogConfig.autoFocus = true;
        dialogConfig.disableClose = true;
        dialogConfig.width = '60%';
        dialogConfig.panelClass = 'form';
        this.dialog.open(CreateProjectComponent, dialogConfig);
    }
    onEdit() {
        this.service.populateForm(this.project);
        const dialogConfig = new MatDialogConfig();
        dialogConfig.disableClose = true;
        dialogConfig.autoFocus = true;
        this.dialog.open(CreateProjectComponent, dialogConfig);
    }
};
ProjectComponent = tslib_1.__decorate([
    Component({
        selector: 'app-project',
        templateUrl: './project.component.html',
        styleUrls: ['./project.component.less'],
        providers: [ProjectService]
    })
], ProjectComponent);
export { ProjectComponent };
//# sourceMappingURL=project.component.js.map