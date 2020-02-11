import { Page } from "../../../../shared/models/page/page.model";
import { Component, OnInit, Input } from "@angular/core";
import { PageService } from "../../../../core/http/manager/page.service";
import { CmsRoute } from "src/app/modules/main/toolbar/toolbar-item/cms-route";

@Component({
  selector: "app-piranha-page",
  templateUrl: "./piranha-page.component.html",
  styleUrls: ["./piranha-page.component.less"]
})
export class PiranhaPageComponent implements OnInit {
  page: Page;
  @Input() cmsRoute: CmsRoute;
  ifGenerate = false;
  constructor(private cmsPageService: PageService) {}

  async ngOnInit() {
    // this.page = await this.cmsPageService.getPageById(
    //   parseInt(this.cmsRoute.id)
    // );
    this.ifGenerate = true;
  }
}
