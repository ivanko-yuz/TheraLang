import { Component, OnInit, Input, Output, ElementRef, EventEmitter } from "@angular/core";

@Component({
  selector: "app-slider-row",
  templateUrl: "./slider-row.component.html",
  styleUrls: ["./slider-row.component.less"],
})
export class SliderRowComponent implements OnInit {

  @Input("images") images: string[];
  @Output("removeImg") removeImg = new EventEmitter<string>();
  constructor(private elRef: ElementRef) { }

  ngOnInit() {
  }

  onRemove(toRemoveUrl: string) {
    this.removeImg.emit(toRemoveUrl);
  }
}
