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
    group: "nested",
    handle: ".handle",
    animation: 600,
    swapThreshold: 0.2,
    fallbackOnBody: true,
    easing: "cubic-bezier(0.25, 0.46, 0.45, 0.94)",
    ghostClass: "sortable-ghost", // Class name for the drop placeholder
    chosenClass: "sortable-chosen", // Class name for the chosen item
    dragClass: "sortable-drag" // Class name for the dragging item
  };
  constructor() {}

  ngOnInit() {}
}
