import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CmsGenericPageComponent } from './components/cms-generic-page/cms-generic-page.component';
import {CmsRoutingModule} from './cms-routing.module';
import { PiranhaPageComponent } from './components/piranha-page/piranha-page.component';
import { BlockComponent } from './components/block/block.component';
import { GalleryBlockComponent } from './components/gallery-block/gallery-block.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import {SiteMapService} from './services/site-map.service';
import {CmsRouteHelperService} from './services/cms-route-helper.service';
import {CmsPageService} from './services/cms-page.service';


@NgModule({
  declarations: [
    CmsGenericPageComponent,
    PiranhaPageComponent,
    BlockComponent,
    GalleryBlockComponent,
  ],
  imports: [
    CommonModule,
    CmsRoutingModule,
    NgbModule,
  ],
  exports: [
    GalleryBlockComponent,
  ],
  providers: [
    SiteMapService,
    CmsRouteHelperService,
    CmsPageService,
  ],
  bootstrap: [
    GalleryBlockComponent
  ]
})
export class CmsModule { }
