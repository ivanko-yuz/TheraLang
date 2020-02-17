import { Component, OnInit } from '@angular/core';
import { SiteMapService } from '../../../../core/http/manager/site-map.service';
import {SiteMap} from "../../../../shared/models/site-map/site-map";
import {Language} from "../../../../shared/models/language/languages.enum";
import {TranslateService} from "@ngx-translate/core";

@Component({
  selector: 'app-cms-pages-toolbar-item',
  templateUrl: './cms-pages-toolbar-item.component.html',
  styleUrls: ['./cms-pages-toolbar-item.component.less', '../toolbar-menu-item.less']
})
export class CmsPagesToolbarItemComponent implements OnInit {

  toolbarItems: SiteMap[] = [];

  constructor(
    private siteMapService: SiteMapService,
    private translateService: TranslateService
  ) { }

  ngOnInit() {
    const lang = Language[this.translateService.currentLang];
    this.siteMapService.getSiteMap(lang).subscribe(
      {
        next: value => {
          this.toolbarItems = value["pages"] as SiteMap[];
        }
      }
    )
  }
}
