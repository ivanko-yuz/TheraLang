import { __awaiter, __decorate } from "tslib";
import { Component, ViewEncapsulation } from '@angular/core';
import { trigger, state, style } from '@angular/animations';
import { HttpService } from '../project/http.service';
import { ProjectParticipationService } from '../project-participants/project-participation.service';
let ProjectInfoComponent = class ProjectInfoComponent {
    constructor(route, http, resourceService, participService, notificationService) {
        this.route = route;
        this.http = http;
        this.resourceService = resourceService;
        this.participService = participService;
        this.notificationService = notificationService;
        this.generateOnceResourcesTable = false;
        this.sortedResourcesByCategory = [];
        this.isOpen = false;
    }
    ngOnInit() {
        this.route.paramMap.subscribe(params => {
            this.projectId = +params.get('id');
            this.http.getProjectInfo(this.projectId).subscribe((data) => this.projectInfo = data);
        });
    }
    getResourcesData() {
        return __awaiter(this, void 0, void 0, function* () {
            if (!this.generateOnceResourcesTable) {
                const allResources = yield this.resourceService.getAllResourcesByProjId(this.projectId);
                this.sortedResourcesByCategory = this.resourceService.sortAllResourcesByCategories(allResources);
            }
            this.isOpen = !this.isOpen;
            this.generateOnceResourcesTable = true;
        });
    }
    onJoin() {
        this.participService.createParticipRequest(this.projectId).subscribe((res) => {
            if (res.ok) {
                this.notificationService.success('Заявку надіслано');
            }
        }, (error) => {
            console.log(error);
            this.notificationService.warn('Неможливо надіслати заявку');
        });
        ;
    }
};
ProjectInfoComponent = __decorate([
    Component({
        selector: 'app-project-info',
        templateUrl: './project-info.component.html',
        styleUrls: ['./project-info.component.less'],
        encapsulation: ViewEncapsulation.None,
        animations: [
            trigger('openClose', [
                state('open', style({
                    display: 'initial'
                })),
                state('closed', style({
                    display: 'none'
                })),
            ]),
        ],
        providers: [HttpService, ProjectParticipationService]
    })
], ProjectInfoComponent);
export { ProjectInfoComponent };
//# sourceMappingURL=project-info.component.js.map