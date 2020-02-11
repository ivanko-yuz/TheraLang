import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { CmsGenericPageComponent } from "./components/cms-generic-page/cms-generic-page.component";
import { CmsRoutingModule } from "./cms-routing.module";
import { PiranhaPageComponent } from "./components/piranha-page/piranha-page.component";
import { BlockComponent } from "./components/block/block.component";
import { GalleryBlockComponent } from "./components/gallery-block/gallery-block.component";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { SiteMapService } from "../../core/http/manager/site-map.service";
import { CmsRouteHelperService } from "../../core/services/cms/cms-route-helper.service";
import { PageService } from "../../core/http/manager/page.service";

@NgModule({
  declarations: [
    CmsGenericPageComponent,
    PiranhaPageComponent,
    BlockComponent,
    GalleryBlockComponent
  ],
  imports: [CommonModule, CmsRoutingModule, NgbModule],
  exports: [GalleryBlockComponent],
  providers: [SiteMapService, CmsRouteHelperService, PageService],
  bootstrap: [GalleryBlockComponent]
})
export class CmsModule {}
