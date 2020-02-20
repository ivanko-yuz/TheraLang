import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { FormBuilder, Validators } from "@angular/forms";
import { accountUrl } from "src/app/configs/api-endpoint.constants";
import { JwtHelperService } from "@auth0/angular-jwt";
import { Roles } from 'src/app/shared/models/roles/roles';
@Injectable({
  providedIn: "root"
})

export class UserService {
  constructor(
    private http: HttpClient,
    private fb: FormBuilder,
    private jwtHelper: JwtHelperService
  ) {}
  loginForm = this.fb.group({
    username: [
      "",
      [Validators.required, Validators.minLength(3), Validators.maxLength(50)]
    ],
    password: [
      "",
      [Validators.required, Validators.minLength(3), Validators.maxLength(50)]
    ]
  });
  readonly baseUrl = accountUrl;
  login(loginData) {
    return this.http.post(this.baseUrl + "/login", loginData);
  }
  logout() {
    localStorage.removeItem("jwt");
  }
  isAuthenticated() {
    let token: string = localStorage.getItem("jwt");
    if (token && !this.jwtHelper.isTokenExpired(token)) {
      return true;
    } else {
      return false;
    }
  }

  isRole(userRole: Roles){
    let token: string = localStorage.getItem("jwt");
    if (token && !this.jwtHelper.isTokenExpired(token)) {
      let role = this.jwtHelper.decodeToken(token)[
        "http://schemas.microsoft.com/ws/2008/06/identity/claims/role"
      ];
      if (role === userRole) {
        return true;
      }
    } else {
      return false;
    }
  }

  getUserName() {
    return this.http.get(this.baseUrl + "/getUserName", {
      responseType: "text"
    });
  }
  getCurrentUserId()
  {
    let token: string = localStorage.getItem("jwt");
    if (token && !this.jwtHelper.isTokenExpired(token)) {
      let jwtData = this.jwtHelper.decodeToken(token);
      let userId = jwtData['Id'];
      return userId;
    }
    else
    return undefined;
  }
}
