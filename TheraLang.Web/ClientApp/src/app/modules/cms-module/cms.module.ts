import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { CmsGenericPageComponent } from "./cms-generic-page/cms-generic-page.component";
import { CmsRoutingModule } from "./cms-routing.module";
import { PiranhaPageComponent } from "./piranha-page/piranha-page.component";
import { BlockComponent } from "./block/block.component";
import { GalleryBlockComponent } from "./gallery-block/gallery-block.component";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { SiteMapService } from "../../core/http/cms/site-map.service";
import { CmsRouteHelperService } from "../../core/services/cms/cms-route-helper.service";
import { CmsPageService } from "../../core/http/cms/cms-page.service";

@NgModule({
  declarations: [
    CmsGenericPageComponent,
    PiranhaPageComponent,
    BlockComponent,
    GalleryBlockComponent
  ],
  imports: [CommonModule, CmsRoutingModule, NgbModule],
  exports: [GalleryBlockComponent],
  providers: [SiteMapService, CmsRouteHelperService, CmsPageService],
  bootstrap: [GalleryBlockComponent]
})
export class CmsModule {}
