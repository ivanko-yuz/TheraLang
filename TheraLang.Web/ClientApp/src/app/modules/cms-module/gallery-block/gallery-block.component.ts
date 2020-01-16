import { Component, OnInit, Input } from "@angular/core";
import { Block } from "../../../shared/models/block/block.model";
import { StringifyOptions } from "querystring";

@Component({
  selector: "app-gallery-block",
  templateUrl: "./gallery-block.component.html",
  styleUrls: ["./gallery-block.component.less"]
})
export class GalleryBlockComponent {
  @Input() block: Block;

  constructor() {}

  cutLink(url: string): string {
    return url.substr(1);
  }
}
