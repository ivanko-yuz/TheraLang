import { Injectable } from '@angular/core';
import { Page } from '../models/page.model';
import { HttpService } from 'src/app/project/http.service';



@Injectable()
export class CmsPageService {
    piranhaPage: Page;
    constructor(private http: HttpService) { }

     async getPiranhaPageById(pageId: string): Promise<Page> {
        const allData = await this.http.getPiranhaPageById(pageId).toPromise().then((data: Page) => data);
        return allData;
    }
}
