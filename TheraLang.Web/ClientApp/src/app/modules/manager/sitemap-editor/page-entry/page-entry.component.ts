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
  @Output() onChange: EventEmitter<ChangedSiteMap[]> = new EventEmitter<
    ChangedSiteMap[]
  >();
  @Output() onSave: EventEmitter<ChangedSiteMap[]> = new EventEmitter<
    ChangedSiteMap[]
  >();
  @Output() onDelete: EventEmitter<number> = new EventEmitter<number>();

  options: Options = {
    group: "nested",
    handle: ".handle",
    animation: 300,
    swapThreshold: 0.2,
    invertSwap: true,
    fallbackOnBody: true,
    ghostClass: "sortable-ghost",
    chosenClass: "sortable-chosen",
    dragClass: "sortable-drag",
    onUnchoose: (event: any) => {
      const from = parseInt(event.from.attributes["page-id"].value);
      const to = parseInt(event.to.attributes["page-id"].value);
      const target = parseInt(event.item.attributes["page-id"].value);
      const siblings = event.to.childNodes;

      const entriesToChange = this.formEvent(from, to, target, siblings);

      // console.log(event);

      this.onChange.emit(entriesToChange);
    }
  };
  constructor() {}

  ngOnInit() {}

  emitToParent(event) {
    this.onChange.emit(event);
  }

  emitOnDeleteToParent(event: number) {
    this.onDelete.emit(event);
  }

  private formEvent(
    from: number,
    to: number,
    target: number,
    siblings: any
  ): ChangedSiteMap[] {
    const entriesToChange: ChangedSiteMap[] = [];
    console.log(siblings);

    siblings.forEach((sibling, index) => {
      if (sibling.classList && sibling.classList.contains("child-item")) {
        const siblingId = parseInt(sibling.attributes["page-id"].value);
        if (siblingId == target) {
          entriesToChange.push({
            id: target,
            prevParentId: from,
            newParentId: to,
            newIndex: index
          });
        } else {
          entriesToChange.push({
            id: siblingId,
            newIndex: index
          });
        }
      }
    });
    return entriesToChange;
  }
}
