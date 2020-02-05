import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { baseUrl } from 'src/app/configs/api-endpoint.constants';
import { Newpage } from 'src/app/shared/models/new_page/newpage';
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from 'src/app/core/services/notification/notification.service';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class PageService {

  constructor(private http: HttpClient,
    private notificationService: NotificationService,
    private translate: TranslateService,
    private router: Router) {
  }
  private url = baseUrl;

  public addPage(page: Newpage) {
    this.http.post(`${this.url}pages/`, page).subscribe(
      async (msg: string) => {
        msg = await this.translate
          .get("common.created-successfully")
          .toPromise();
        this.notificationService.success(msg);
        this.router.navigate(['admin', 'sitemap']);
      },
      async error => {
        console.log(error);
        this.notificationService.warn(
          await this.translate.get("common.wth").toPromise()
        );
      }
    );
  }

  public updatePage(page: Newpage) {
    this.http.put(`${this.url}pages/${page.id}`, page).subscribe(
      async (msg: string) => {
        msg = await this.translate.get("common.updated-successfully").toPromise();
        this.notificationService.success(msg);
        this.router.navigate(['admin', 'sitemap']);
      },
      async error => {
        console.log(error);
        this.notificationService.warn(
          await this.translate.get("common.wth").toPromise()
        );
      }
    );
  }

  public getPageById(pageId: string) {
    return this.http.get(`${this.url}pages/id${pageId}`);
  }
}
