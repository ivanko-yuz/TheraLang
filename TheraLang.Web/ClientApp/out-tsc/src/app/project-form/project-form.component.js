import { __decorate } from "tslib";
import { Component } from '@angular/core';
import { ProjectService } from '../project/project.service';
let ProjectFormComponent = class ProjectFormComponent {
    constructor(dialog, service, dateAdapter) {
        this.dialog = dialog;
        this.service = service;
        this.dateAdapter = dateAdapter;
    }
    ngOnInit() {
        this.dateAdapter.setLocale('uk'),
            this.dateAdapter.getFirstDayOfWeek = () => { return 1; };
    }
    onClose() {
        this.service.form.reset();
        this.service.initializeFormGroup();
        this.dialog.close();
    }
    onSubmit() {
        if (this.service.form.invalid) {
            const controls = this.service.form.controls;
            Object.keys(controls)
                .forEach(controlName => controls[controlName].markAsTouched());
            return;
        }
        else if (!this.service.form.get('id').value) {
            this.service.addProject(this.service.form.value);
            this.onClose();
        }
        else {
            this.service.editProject(this.service.form.value);
            this.onClose();
        }
    }
};
ProjectFormComponent = __decorate([
    Component({
        selector: 'app-create-project',
        templateUrl: './project-form.component.html',
        styleUrls: ['./project-form.component.less'],
        providers: [ProjectService]
    })
], ProjectFormComponent);
export { ProjectFormComponent };
//# sourceMappingURL=project-form.component.js.map