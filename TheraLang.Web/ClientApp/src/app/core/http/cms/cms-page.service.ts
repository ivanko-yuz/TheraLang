import { Injectable } from "@angular/core";
import { Page } from "../../../shared/models/page/page.model";
import { HttpClient } from "@angular/common/http";
import { cmsPageUrl } from "src/app/configs/api-endpoint.constants";
import { Observable } from "rxjs";

@Injectable()
export class CmsPageService {
  piranhaPage: Page;
  url: string;
  constructor(private http: HttpClient) {}

  async getPiranhaPageById(pageId: number): Promise<Page> {
    const allData = await this.http
      .get(cmsPageUrl + pageId)
      .toPromise()
      .then((data: Page) => data);
    return allData;
  }

  deletePage(pageId: number): Observable<any> {
    return this.http.delete(cmsPageUrl + pageId);
  }
}
