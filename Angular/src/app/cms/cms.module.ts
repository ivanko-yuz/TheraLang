import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CmsGenericPageComponent } from './components/cms-generic-page/cms-generic-page.component';
import {CmsRoutingModule} from './cms-routing.module';


@NgModule({
  declarations: [CmsGenericPageComponent],
  imports: [
    CommonModule,
    CmsRoutingModule,
  ],
  exports: []
})
export class CmsModule { }
