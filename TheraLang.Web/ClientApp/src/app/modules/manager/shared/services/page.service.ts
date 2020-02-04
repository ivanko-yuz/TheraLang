import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { baseUrl } from 'src/app/configs/api-endpoint.constants';
import { Newpage } from 'src/app/shared/models/new_page/newpage';
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from 'src/app/core/services/notification/notification.service';

@Injectable({
  providedIn: 'root'
})
export class PageService {

  constructor(private http: HttpClient) {
  }

  private url = baseUrl;
  private notificationService: NotificationService;
  private translate: TranslateService;

  public addPage(page: Newpage) {
    return this.http.post(this.url + "pages", page).subscribe(
      async (msg: string) => {
        msg = await this.translate
          .get("common.created-successfully")
          .toPromise();
        this.notificationService.success(msg);
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
