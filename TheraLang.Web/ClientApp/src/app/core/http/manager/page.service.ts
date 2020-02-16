import { Injectable } from "@angular/core";
import { Page } from "../../../shared/models/page/page.model";
import { HttpClient } from "@angular/common/http";
import { managerPageUrl } from "src/app/configs/api-endpoint.constants";
import { Observable } from "rxjs";
import { NotificationService } from "../../services/notification/notification.service";
import { TranslateService } from "@ngx-translate/core";
import { Router } from "@angular/router";
import {Language} from "../../../shared/models/language/languages.enum";

@Injectable()
export class PageService {
  constructor(
    private http: HttpClient,
    private translateService: TranslateService,
    ) {}

  addPage(page: Page[]) {
    return this.http.post(`${managerPageUrl}`, page);
  }

  updatePage(page: Page) {
    return this.http.put(`${managerPageUrl}${page.id}`, page);
  }

  getPageById(pageId: number) {
    return this.http.get(`${managerPageUrl}id${pageId}`);
  }

  getPageByRoute(route: string) {
    const lang = Language[this.translateService.currentLang];
    return this.http.get(`${managerPageUrl}${lang}/${route}`);
  }

  deletePage(pageId: number): Observable<any> {
    return this.http.delete(managerPageUrl + pageId);
  }
}
