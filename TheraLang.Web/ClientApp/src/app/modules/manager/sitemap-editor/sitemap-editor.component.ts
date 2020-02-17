import { Component, OnInit } from "@angular/core";
import { SiteMapService } from "src/app/core/http/manager/site-map.service";
import { SiteMap } from "src/app/shared/models/site-map/site-map";
import { ChangedSiteMap } from "src/app/shared/models/site-map/changed-site-map";
import { PageService } from "src/app/core/http/manager/page.service";
import { NotificationService } from "src/app/core/services/notification/notification.service";
import { TranslateService } from "@ngx-translate/core";
import {Language} from "../../../shared/models/language/languages.enum";

@Component({
  selector: "app-sitemap-editor",
  templateUrl: "./sitemap-editor.component.html",
  styleUrls: ["./sitemap-editor.component.less"]
})
export class SitemapEditorComponent implements OnInit {
  public siteMap: SiteMap[];
  private language: Language;
  constructor(
    private siteMapService: SiteMapService,
    private pageService: PageService,
    private notificationService: NotificationService,
    private translateService: TranslateService
  ) {}

  ngOnInit() {
    this.language = Language.ua;
    this.fetchData();
  }
  fetchData() {
    this.siteMapService.getSiteMap(this.language).subscribe({
      next: data => {
        this.siteMap = data["pages"] as SiteMap[];
      }
    });
  }

  onMove(event: ChangedSiteMap[]) {
    this.siteMapService.addSiteMapChange(event);
  }

  onSave() {
    this.siteMapService.updateSiteMapStructure().subscribe(async resp => {
      const msg = await this.translateService
        .get("common.saved-successfully")
        .toPromise();
      this.notificationService.success(msg);
    });
  }

  onDelete(pageId: number) {
    this.pageService.deletePage(pageId).subscribe({
      next: async res => {
        const msg = await this.translateService
          .get("common.deleted-successfully")
          .toPromise();
        this.siteMapService.tryRemoveFromChanges(pageId);
        this.fetchData();
        this.notificationService.success(msg);
      },
      error: err => {
        console.log(err);
      }
    });
  }

  changeLanguage(lang:string){
    this.language = Language[lang];
    this.fetchData();
  }
}
