import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { TypeProject } from "./TypeProject";
import { Observable } from "rxjs";
import { typeProjectUrl } from "../shared/api-endpoint.constants";

@Injectable()
export class TypeProjectHttp {
  constructor(private http: HttpClient) {}

  put(typeProjectUrl: string, data: TypeProject): Observable<any> {
    return this.http.put(typeProjectUrl, data);
  }

  delete(id: number): Observable<any> {
    return this.http.delete(typeProjectUrl + id, { observe: "response" });
  }

  post(newTypeProject: TypeProject): Observable<any> {
    return this.http.post(typeProjectUrl, newTypeProject);
  }
}
