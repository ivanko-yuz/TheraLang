import { Component, OnInit } from '@angular/core';
import { SiteMapService } from '../../../../core/http/manager/site-map.service';
import {SiteMap} from "../../../../shared/models/site-map/site-map";

@Component({
  selector: 'app-cms-pages-toolbar-item',
  templateUrl: './cms-pages-toolbar-item.component.html',
  styleUrls: ['./cms-pages-toolbar-item.component.less', '../toolbar-menu-item.less']
})
export class CmsPagesToolbarItemComponent implements OnInit {

  toolbarItems: SiteMap[] = [];

  constructor(
    private siteMapService: SiteMapService
  ) { }

  ngOnInit() {
    this.siteMapService.getSiteMap().subscribe(
      {
        next: value => {
          this.toolbarItems = value["pages"] as SiteMap[];
        }
      }
    )
  }
}
