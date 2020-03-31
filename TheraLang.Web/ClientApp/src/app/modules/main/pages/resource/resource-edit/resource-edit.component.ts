import { Component, OnInit } from "@angular/core";
import {Resource} from "../../../../../shared/models/resource/resource";
import {ActivatedRoute, Router} from "@angular/router";
import {ResourceService} from "../../../../../core/http/resource/resource.service";

@Component({
  selector: "app-resource-edit",
  templateUrl: "./resource-edit.component.html",
  styleUrls: ["./resource-edit.component.less"],
})
export class ResourceEditComponent implements OnInit {

  resource: Resource;
  loaded = false;

  constructor(
    private route: ActivatedRoute,
    private resourceService: ResourceService,
    private router: Router,
  ) { }

  ngOnInit() {
    let resourceId;
    this.route.params.subscribe(params => {
      resourceId = parseInt(params.resourceId);
      this.resourceService.getResource(resourceId).subscribe(res => {
          this.resource = res as Resource;
          this.loaded = true;
        });
    });
  }

  onSubmit(resource: Resource) {
    const categoryId = resource.categoryId;
    this.resourceService.updateResource(resource).subscribe(res => this.router.navigateByUrl(`/resources/${categoryId}`));
  }

  onCancel() {
    this.router.navigateByUrl("/resources");
  }

}
