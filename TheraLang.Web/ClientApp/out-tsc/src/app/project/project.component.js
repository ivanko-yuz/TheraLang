import { __decorate } from "tslib";
import { Component } from '@angular/core';
import { ProjectFormComponent } from '../project-form/project-form.component';
import { ProjectService } from './project.service';
let ProjectComponent = class ProjectComponent {
    constructor(httpService, dialogService, service) {
        this.httpService = httpService;
        this.dialogService = dialogService;
        this.service = service;
    }
    ngOnInit() {
        this.httpService.getAllProjects().subscribe((projects) => this.projects = projects);
    }
    onCreate() {
        this.service.initializeFormGroup();
        this.dialogService.openFormDialog(ProjectFormComponent);
    }
    onEdit(project) {
        this.service.populateForm(project);
        this.dialogService.openFormDialog(ProjectFormComponent);
    }
};
ProjectComponent = __decorate([
    Component({
        selector: 'app-project',
        templateUrl: './project.component.html',
        styleUrls: ['./project.component.less'],
        providers: [ProjectService]
    })
], ProjectComponent);
export { ProjectComponent };
//# sourceMappingURL=project.component.js.map