import { Component, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { TypeProject } from "./TypeProject";
import { Observable } from "rxjs";
import { TypeProjectHttp } from "./TypeProjectHttp.service";
import { error } from "@angular/compiler/src/util";

@Component({
  selector: "app-type-project",
  templateUrl: "./type-project.component.html",
  styleUrls: ["./type-project.component.less"]
})
export class TypeProjectComponent implements OnInit {
  constructor(private http: TypeProjectHttp) {}
  private url = "https://localhost:44355/api/typeProject";
  myvalue: string;

  ngOnInit() {}

  onClick() {
    console.log("log btn click ");
    this.btnPut();
  }

  btnPut() {
    let putUrl = this.url + "/" + 1;
    let newProj: TypeProject = new TypeProject(1, "updated");
    this.http.put(putUrl, newProj).subscribe(
      response => {
        //to do snackBar
      },
      error => {
        //to do snackBar
      }
    );
  }

  btnPost(newTypeProject: TypeProject): Observable<any> {
    this.http.post(newTypeProject).subscribe(
      response => {
        //to do snackBar
      },
      error => {
        //to do snackBar
      }
    );
    return;
  }

  btnDelete(id: number) {
    let code: number;
    this.http.delete(id).subscribe(
      response => {
        //to do snackBar
      },
      error => {
        //to do snackBar
      }
    );
  }
}
