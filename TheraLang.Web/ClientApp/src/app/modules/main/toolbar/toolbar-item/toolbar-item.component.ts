import {Component, ElementRef, Input, OnInit, ViewChild} from "@angular/core";
import { ToolbarItem } from "../cms-pages-toolbar-item/toolbar-item";
import { CmsRouteHelperService } from "../../../../core/services/cms/cms-route-helper.service";
import {SiteMap} from "../../../../shared/models/site-map/site-map";
import {MatMenu} from "@angular/material/menu";
import {log} from "util";

@Component({
  selector: "app-toolbar-item",
  templateUrl: "./toolbar-item.component.html",
  styleUrls: ["./toolbar-item.component.less"]
})
export class ToolbarItemComponent implements OnInit {
  @Input() toolbarItem: SiteMap;

  @ViewChild("menu", { static: false }) menu: any;

  constructor() {}

  ngOnInit() {
  }

  isFinalMenu(): boolean {
    return !this.needSubMenus();
  }

  needSubMenus(): boolean {
    return this.toolbarItem.subPages.length > 0; // && this.toolbarItem.cmsRoute.pageTypeName !== 'Blog archive';
    // TODO: adjust if you need exclude
  }
}
