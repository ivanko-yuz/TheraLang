import { Component, OnInit } from "@angular/core";
import { SiteMapService } from "src/app/core/http/cms/site-map.service";
import { SiteMap } from "src/app/shared/models/site-map/site-map";
import { ChangedSiteMap } from "src/app/shared/models/site-map/changed-site-map";
import { CmsPageService } from "src/app/core/http/cms/cms-page.service";

@Component({
  selector: "app-sitemap-editor",
  templateUrl: "./sitemap-editor.component.html",
  styleUrls: ["./sitemap-editor.component.less"]
})
export class SitemapEditorComponent implements OnInit {
  public siteMap: SiteMap[];
  constructor(
    private siteMapService: SiteMapService,
    private pageService: CmsPageService
  ) {}

  ngOnInit() {
    this.fetchData();
  }
  fetchData() {
    this.siteMapService.getSiteMap().subscribe({
      next: data => {
        this.siteMap = data["pages"] as SiteMap[];
      }
    });
  }

  onMove(event: ChangedSiteMap[]) {
    this.siteMapService.addSiteMapChange(event);
  }

  logInfo() {
    console.log(this.siteMapService.changesToMake);
  }
  onSave() {
    this.siteMapService
      .updateSiteMapStructure()
      .subscribe(resp => console.log(resp));
  }

  onDelete(pageId: number) {
    this.pageService.deletePage(pageId).subscribe({
      next: res => {
        this.siteMapService.tryRemoveFromChanges(pageId);
        this.fetchData();
      },
      error: err => {
        console.log(err);
      }
    });
  }
}
