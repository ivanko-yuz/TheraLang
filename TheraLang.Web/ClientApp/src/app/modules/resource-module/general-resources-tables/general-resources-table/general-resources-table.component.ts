import { Component, OnInit, ViewEncapsulation } from "@angular/core";
import { ResourceCategory } from "../../../../shared/models/resource/resource-category";
import * as Constants from "../../../../configs/resources-table";
import { ResourceCreateService } from "../../../../core/http/resource/resource-create.service";
import { ResourceCreateComponent } from "../../resource-create/resource-create.component";
import { ResourceService } from "src/app/core/http/resource/resource.service";
import { ResourceCategoriesService } from "src/app/core/services/resource/resource-categories.service";
import { DialogService } from "src/app/core/services/dialog/dialog.service";

@Component({
  selector: "app-general-resources-table",
  templateUrl: "./general-resources-table.component.html",
  styleUrls: ["./general-resources-table.component.less"],
  encapsulation: ViewEncapsulation.None
})
export class GeneralResourcesTableComponent implements OnInit {
  resourcesCategories: ResourceCategory[];
  showCategories = false;
  dataSource;
  constructor(
    public resourceService: ResourceService,
    public resourceCategoriesService: ResourceCategoriesService,
    public resourceCreateService: ResourceCreateService,
    public dialogService: DialogService
  ) {}

  async ngOnInit() {
    this.resourcesCategories = await this.resourceCategoriesService.getResourceCategories(
      Constants.ResourcesTableConstants.WITH_ASSIGNED_RESOURCES
    );
    this.showCategories = true;
  }

  addResource() {
    this.resourceCreateService.initializeForm();
    this.dialogService.openFormDialog(ResourceCreateComponent);
  }
}
