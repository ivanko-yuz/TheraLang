import { Injectable } from "@angular/core";
import { HttpClient, HttpEventType } from "@angular/common/http";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root"
})
export class FileService {
  constructor(private http: HttpClient) {}

  public uploadFile(file: File): Observable<any> {
    if (file.size == 0) {
      return;
    }
    const formData = new FormData();
    formData.append("file", file);

    return this.http.post("http://localhost:5000/api/file/upload", formData, {
      reportProgress: true,
      observe: "events"
    });
  }
}
