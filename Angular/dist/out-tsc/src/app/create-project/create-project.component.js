import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { ProjectService } from '../project/shared/project.service';
let CreateProjectComponent = class CreateProjectComponent {
    constructor(dialogRef, service) {
        this.dialogRef = dialogRef;
        this.service = service;
    }
    ngOnInit() {
    }
    onClose() {
        this.service.form.reset();
        this.service.initializeFormGroup();
        this.dialogRef.close();
    }
    onSubmit() {
        if (this.service.form.valid) {
            if (!this.service.form.get('id').value)
                this.service.addProject(this.service.form.value);
            else
                this.service.editProject(this.service.form.value);
            this.onClose();
        }
        else {
            const controls = this.service.form.controls;
            Object.keys(controls)
                .forEach(controlName => controls[controlName].markAsTouched());
            return;
        }
    }
};
CreateProjectComponent = tslib_1.__decorate([
    Component({
        selector: 'app-create-project',
        templateUrl: './create-project.component.html',
        styleUrls: ['./create-project.component.less'],
        providers: [ProjectService]
    })
], CreateProjectComponent);
export { CreateProjectComponent };
//# sourceMappingURL=create-project.component.js.map