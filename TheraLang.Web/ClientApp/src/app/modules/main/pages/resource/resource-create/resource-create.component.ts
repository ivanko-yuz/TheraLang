import { Component, OnInit } from "@angular/core";
import {Resource} from "../../../../../shared/models/resource/resource";
import {ResourceService} from "../../../../../core/http/resource/resource.service";
import {NotificationService} from "../../../../../core/services/notification/notification.service";
import {Router} from "@angular/router";
import {TranslateService} from "@ngx-translate/core";

@Component({
  selector: "app-resource-create",
  templateUrl: "./resource-create.component.html",
  styleUrls: ["./resource-create.component.less"]
})
export class ResourceCreateComponent implements OnInit {

  constructor(
    private resourceService: ResourceService,
    private notificationService: NotificationService,
    private router: Router,
    private translate : TranslateService
  ) {
  }

  ngOnInit(){
  }

  onSubmit(submittedResource: Resource) {
    this.resourceService.postResource(submittedResource).subscribe(
      async response => {
        this.notificationService.success(
          await this.translate.get("common.created-successfully").toPromise()
        );
        await this.router.navigateByUrl(`/resources/${submittedResource.categoryId || ""}`);
      },
      async error => {
        this.notificationService.warn(
          await this.translate.get("common.wth").toPromise()
        );
      }
    );
  }
  onCancel(){
    this.router.navigateByUrl("/resources");
  }
}
