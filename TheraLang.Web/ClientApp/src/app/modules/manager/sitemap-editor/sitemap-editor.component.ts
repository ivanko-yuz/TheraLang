import { Component, OnInit } from "@angular/core";
import { SiteMapService } from "src/app/core/http/cms/site-map.service";
import { SiteMap } from "src/app/shared/models/site-map/site-map";

@Component({
  selector: "app-sitemap-editor",
  templateUrl: "./sitemap-editor.component.html",
  styleUrls: ["./sitemap-editor.component.less"]
})
export class SitemapEditorComponent implements OnInit {
  public siteMap: SiteMap[];
  constructor(private siteMapService: SiteMapService) {}

  ngOnInit() {
    this.siteMapService.getSiteMap().subscribe({
      next: data => {
        this.siteMap = data["pages"] as SiteMap[];
        console.log(this.siteMap);
      }
    });
  }

  logInfo() {
    console.log(this.siteMap);
  }
}
