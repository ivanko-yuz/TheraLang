import { Component, OnInit, Input } from "@angular/core";
import { SiteMap } from "src/app/shared/models/site-map/site-map";
import { Options } from "sortablejs";

@Component({
  selector: "app-page-entry",
  templateUrl: "./page-entry.component.html",
  styleUrls: ["./page-entry.component.less"]
})
export class PageEntryComponent implements OnInit {
  @Input("page") page: SiteMap;
  @Input() isRoot: boolean;

  options: Options = {
    group: "test"
  };
  constructor() {}

  ngOnInit() {}
}
