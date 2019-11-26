import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CmsGenericPageComponent } from './components/cms-generic-page/cms-generic-page.component';
import {CmsRoutingModule} from './cms-routing.module';
import { PiranhaPageComponent } from '../cms-api/piranha-page/piranha-page.component';
import { BlockComponent } from '../cms-api/cms-shared/block/block.component';
import { GalleryBlockComponent } from '../cms-api/cms-shared/gallery-block/gallery-block.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';


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
  bootstrap: [
    GalleryBlockComponent
  ]
})
export class CmsModule { }
