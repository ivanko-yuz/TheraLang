import { Page } from '../../models/page.model';
import { Component, OnInit, Input } from '@angular/core';
import { CmsRoute } from 'src/app/toolbar/toolbar-item/cms-route';
import { CmsPageService } from '../../services/cms-page.service';

@Component({
  selector: 'app-piranha-page',
  templateUrl: './piranha-page.component.html',
  styleUrls: ['./piranha-page.component.less']
})
export class PiranhaPageComponent implements OnInit {
  page: Page;
  @Input() cmsRoute: CmsRoute;
  ifGenerate = false;
  constructor(private cmsPageService: CmsPageService) { }

  async ngOnInit() {
    this.page = await this.cmsPageService.getPiranhaPageById(this.cmsRoute.id);
    this.ifGenerate = true;
  }
}
