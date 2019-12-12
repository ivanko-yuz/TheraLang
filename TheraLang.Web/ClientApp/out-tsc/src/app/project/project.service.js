import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
import { Validators } from '@angular/forms';
let ProjectService = class ProjectService {
    constructor(fb, httpService, notificationService) {
        this.fb = fb;
        this.httpService = httpService;
        this.notificationService = notificationService;
        this.form = this.fb.group({
            id: [null],
            name: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
            description: ['', [Validators.required, Validators.maxLength(8000)]],
            details: ['', Validators.maxLength(8000)],
            projectStart: ['', Validators.required],
            projectEnd: [''],
            type: ['', [Validators.required, Validators.minLength(3)]],
        });
    }
    initializeFormGroup() {
        this.form.setValue({
            id: null,
            name: '',
            description: '',
            details: '',
            projectStart: '',
            projectEnd: '',
            type: '',
        });
    }
    populateForm(project) {
        this.form.setValue(project);
    }
    addProject(project) {
        this.httpService.createProject(project).subscribe((res) => {
            if (res.ok) {
                this.notificationService.success('Проект успішно створено');
            }
        }, (error) => {
            console.log(error);
            this.notificationService.warn('Помилка при створенні');
        });
    }
    editProject(project) {
        this.httpService.updateProject(project).subscribe((res) => {
            if (res.ok) {
                this.notificationService.success('Проект успішно оновлено');
            }
        }, (error) => {
            console.log(error);
            this.notificationService.warn('Помилка при оновленні');
        });
    }
};
ProjectService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], ProjectService);
export { ProjectService };
//# sourceMappingURL=project.service.js.map