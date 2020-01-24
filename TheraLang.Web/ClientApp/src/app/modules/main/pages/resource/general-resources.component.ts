import {
  Component,
  OnInit,
  ViewEncapsulation,
  ViewChild,
  ElementRef
} from "@angular/core";
import { Resource } from "src/app/shared/models/resource/resource";
import { ResourceService } from "src/app/core/http/resource/resource.service";

@Component({
  selector: "app-general-resources",
  templateUrl: "./general-resources.component.html",
  styleUrls: ["./general-resources.component.less"],
  encapsulation: ViewEncapsulation.None
})
export class GeneralResourcesComponent implements OnInit {
  sortedResourcesByCategory: Resource[][] = [];
  constructor(private resourceService: ResourceService) {}
  async ngOnInit() {
    const allResources = await this.resourceService.getAllResourcesByProjId(
      null
    );
    this.sortedResourcesByCategory = this.resourceService.sortAllResourcesByCategories(
      allResources
    );
  }
}
