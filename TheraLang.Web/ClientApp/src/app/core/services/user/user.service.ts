import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { FormBuilder, Validators } from "@angular/forms";
import {accountUrl, userUrl} from "src/app/configs/api-endpoint.constants";
import { JwtHelperService } from "@auth0/angular-jwt";
@Injectable({
  providedIn: "root"
})
export class UserService {
  constructor(
    private http: HttpClient,
    private fb: FormBuilder,
    private jwtHelper: JwtHelperService
  ) {}

  readonly baseUrl = userUrl;

  list() {
    return this.http.get(this.baseUrl);
  }

  changeRole(userID: string, roleID: string) {
    return this.http.post(this.baseUrl + `/${userID}/role`, {
      new_role: roleID,
    });
  }

  getRole(userID: string) {
    return this.http.get(this.baseUrl + `/${userID}/role`);
  }

  getUser(userID: string) {
    return this.http.get(this.baseUrl + `/${userID}`);
  }

  me() {
    return this.http.get(this.baseUrl + "/me");
  }

  getRoles() {
    return this.http.get(this.baseUrl + "/roles");
  }
}
