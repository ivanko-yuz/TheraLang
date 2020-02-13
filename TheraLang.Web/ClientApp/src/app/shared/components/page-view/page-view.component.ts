import { Component, OnInit, Input } from "@angular/core";
import { Page } from "../../models/page/page.model";

@Component({
  selector: "app-page-view",
  templateUrl: "./page-view.component.html",
  styleUrls: ["./page-view.component.less"]
})
export class PageViewComponent implements OnInit {
  @Input() page: Page;

  constructor() {}

  ngOnInit() {}
}
