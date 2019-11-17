import { HttpClient } from '@angular/common/http';
import { Injectable } from "@angular/core";
import { RootObject } from '../when-get-page-by-slug/root-object.mode';
@Injectable()
export class CmsService {
  page: RootObject;

  url: string = "http://localhost:5000/api/page/7eddc055-fd64-45ca-af6d-7002b1f6db89";

  constructor(private http: HttpClient) {    
  }
  async getAboutPage(): Promise<RootObject> {
    const dataaa = await this.http.get(this.url).toPromise().then((data: RootObject) => data)
    return dataaa;
  }
    
}
