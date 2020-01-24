import { Component, OnInit } from '@angular/core';
import { SiteMapService } from '../../http/cms/site-map.service';
import { ToolbarItem } from './toolbar-item';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-cms-pages-toolbar-item',
  templateUrl: './cms-pages-toolbar-item.component.html',
  styleUrls: ['./cms-pages-toolbar-item.component.less', '../toolbar-menu-item.less']
})
export class CmsPagesToolbarItemComponent implements OnInit {

  toolbarItems: ToolbarItem[] = [];
  private subscription = new Subscription();

  constructor(
    private siteMapService: SiteMapService
  ) { }

  ngOnInit() {
    this.subscribeOnSiteMapService();
  }

  subscribeOnSiteMapService(): void {
    const toolbarItemsSubscription = this.siteMapService.toolbarItems.subscribe(
      next => (this.toolbarItems = next),
      error => "do nothing for now"
    );
    this.subscription.add(toolbarItemsSubscription);
  }
}
