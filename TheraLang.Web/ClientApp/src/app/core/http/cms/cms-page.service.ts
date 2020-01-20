import { Injectable } from "@angular/core";
import { Page } from "../../../shared/models/page/page.model";
import { HttpService } from "../http/http.service";

@Injectable()
export class CmsPageService {
  piranhaPage: Page;
  constructor(private http: HttpService) {}

  async getPiranhaPageById(pageId: string): Promise<Page> {
    const allData = await this.http
      .getPiranhaPageById(pageId)
      .toPromise()
      .then((data: Page) => data);
    return allData;
  }
}
