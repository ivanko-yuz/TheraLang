import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { baseUrl } from 'src/app/configs/api-endpoint.constants';
import { Newpage } from 'src/app/shared/models/new_page/newpage';
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from 'src/app/core/services/notification/notification.service';
import { Location } from '@angular/common';

@Injectable({
  providedIn: 'root'
})
export class PageService {

  constructor(private http: HttpClient, 
    private notificationService: NotificationService,
    private translate: TranslateService,
    private location: Location) {
  }
  private url = baseUrl;

  public addPage(page: Newpage) {
    this.http.post(this.url + "pages", page).subscribe(
      async (msg: string) => {
        msg = await this.translate
          .get("common.created-successfully")
          .toPromise();
        this.notificationService.success(msg);
        this.location.back();
      },
      async error => {
        console.log(error);
        this.notificationService.warn(
          await this.translate.get("common.wth").toPromise()
          );
      }
    );
  }
}
