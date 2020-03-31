import { Component, OnInit, Input } from "@angular/core";
import { NewsPreview } from "src/app/shared/models/news/newsPreview";

@Component({
  selector: "app-news-card",
  templateUrl: "./news-card.component.html",
  styleUrls: ["./news-card.component.less"],
})
export class NewsCardComponent implements OnInit {
  @Input() news: NewsPreview;
  constructor() { }

  ngOnInit() {
  }
}
