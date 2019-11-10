import * as tslib_1 from "tslib";
import { forwardRef, Inject } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { HttpProjectService } from '../shared/http-project.service';
// @Injectable({
//   providedIn: 'root'
// })
let ProjectService = class ProjectService {
    constructor(httpService, fb = new FormBuilder()) {
        this.httpService = httpService;
        this.fb = fb;
        this.form = this.fb.group({
            id: [null],
            name: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
            description: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(8000)]],
            type: ['', [Validators.required, Validators.minLength(3)]],
        });
    }
    initializeFormGroup() {
        this.form.setValue({
            id: null,
            name: '',
            description: '',
            type: '',
        });
    }
    populateForm(project) {
        this.form.setValue(project);
    }
    addProject(project) {
        this.httpService.createProject(project);
    }
    editProject(project) {
        this.httpService.updateProject(project);
    }
};
ProjectService = tslib_1.__decorate([
    tslib_1.__param(0, Inject(forwardRef(() => HttpProjectService)))
], ProjectService);
export { ProjectService };
//# sourceMappingURL=project.service.js.map