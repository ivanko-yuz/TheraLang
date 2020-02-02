import { Component, Input, OnInit, ViewChild } from "@angular/core";
import { ToolbarItem } from "../cms-pages-toolbar-item/toolbar-item";
import { CmsRouteHelperService } from "../../../../core/services/cms/cms-route-helper.service";

@Component({
  selector: "app-toolbar-item",
  templateUrl: "./toolbar-item.component.html",
  styleUrls: ["./toolbar-item.component.less"]
})
export class ToolbarItemComponent implements OnInit {
  @Input() toolbarItem: ToolbarItem;

  @ViewChild("menu", { static: false }) menu: any;

  constructor(private cmsRouteHelperService: CmsRouteHelperService) {}

  ngOnInit() {}

  isFinalMenu(): boolean {
    return !this.needSubMenus();
  }

  needSubMenus(): boolean {
    return this.toolbarItem.subItems.length > 0; // && this.toolbarItem.cmsRoute.pageTypeName !== 'Blog archive';
    // TODO: adjust if you need exclude
  }

  onClick() {
    this.cmsRouteHelperService.updateRoute(this.toolbarItem.cmsRoute);
  }
}
