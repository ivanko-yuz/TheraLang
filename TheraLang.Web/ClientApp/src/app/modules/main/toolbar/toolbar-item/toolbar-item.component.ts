import {Component, Input, OnInit, ViewChild} from "@angular/core";
import {SiteMap} from "../../../../shared/models/site-map/site-map";

@Component({
  selector: "app-toolbar-item",
  templateUrl: "./toolbar-item.component.html",
  styleUrls: ["./toolbar-item.component.less"],
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
