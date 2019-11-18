import { Injectable, OnDestroy } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { TypeProject } from "./TypeProject";
import { Observable } from "rxjs";

@Injectable()
export class TypeProjectHttp {
  constructor(private http: HttpClient) {}

  private url = "https://localhost:44355/api/"; //private url = "https://localhost:4435/api/";

  put(url: string, data: TypeProject): Observable<any> {
    return this.http.put(url, data);
  }

  delete(id: number): Observable<any> {
    return this.http.delete(this.url + "/" + id, { observe: "response" });
  }

  post(newTypeProject: TypeProject): Observable<any> {
    return this.http.post(this.url, newTypeProject);
  }
}
