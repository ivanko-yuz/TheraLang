import * as tslib_1 from "tslib";
import { Component, ViewEncapsulation } from '@angular/core';
import * as $ from 'jquery';
import { HttpProjectService } from '../project/shared/http-project.service';
let ProjectInfoComponent = class ProjectInfoComponent {
    constructor(route, http) {
        this.route = route;
        this.http = http;
    }
    ;
    ngOnInit() {
        this.route.paramMap.subscribe(params => {
            let id = +params.get('id');
            this.http.getProjectInfo(id).subscribe((data) => this.projectInfo = data);
            this.http.getAllResourcesById(id).subscribe((_data) => this.projectResources = _data);
            $(document).ready(function () {
                $(".resTab").hide();
            });
            $(".resButton").click(function () {
                $(".resTab").slideToggle("slow");
            });
        });
    }
};
ProjectInfoComponent = tslib_1.__decorate([
    Component({
        selector: 'app-project-info',
        templateUrl: './project-info.component.html',
        styleUrls: ['./project-info.component.less'],
        encapsulation: ViewEncapsulation.None,
        providers: [HttpProjectService]
    })
], ProjectInfoComponent);
export { ProjectInfoComponent };
//# sourceMappingURL=project-info.component.js.map