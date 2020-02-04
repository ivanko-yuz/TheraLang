import { Component, OnInit, Input, Output, EventEmitter } from "@angular/core";
import { SiteMap } from "src/app/shared/models/site-map/site-map";
import { Options } from "sortablejs";
import { ChangedSiteMap } from "src/app/shared/models/site-map/changed-site-map";

@Component({
  selector: "app-page-entry",
  templateUrl: "./page-entry.component.html",
  styleUrls: ["./page-entry.component.less"]
})
export class PageEntryComponent implements OnInit {
  @Input("page") page: SiteMap;
  @Input() isRoot: boolean;
  @Output("onChange") onChange: EventEmitter<ChangedSiteMap> = new EventEmitter<
    ChangedSiteMap
  >();

  options: Options = {
    group: "nested",
    handle: ".handle",
    animation: 300,
    swapThreshold: 0.2,
    invertSwap: true,
    fallbackOnBody: true,
    // easing: "cubic-bezier(0.25, 0.46, 0.45, 0.94)",
    ghostClass: "sortable-ghost", // Class name for the drop placeholder
    chosenClass: "sortable-chosen", // Class name for the chosen item
    dragClass: "sortable-drag", // Class name for the dragging item
    onUnchoose: (event: any) => {
      const from = event.from.attributes["page-id"].value;
      const to = event.to.attributes["page-id"].value;
      const target = event.item.attributes["page-id"].value;
      const changedSiteMap: ChangedSiteMap = {
        id: target,
        prevParentId: from,
        newParentId: to
      };
      console.log(event);

      this.onChange.emit(changedSiteMap);
    },
    onChange: (event: any) => {
      console.log(event);
    }
  };
  constructor() {}

  ngOnInit() {}

  emitToParent(event) {
    this.onChange.emit(event);
  }
}
