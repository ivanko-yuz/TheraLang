import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { FormBuilder, Validators } from "@angular/forms";
import { accountUrl } from "src/app/configs/api-endpoint.constants";
import { JwtHelperService } from '@auth0/angular-jwt';
@Injectable({
  providedIn: "root"
})
export class UserService {
  constructor(private http: HttpClient, private fb: FormBuilder, private jwtHelper: JwtHelperService) {}
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
      }
      else {
        return false;
      }
  }
  isAdmin() {
    let token: string = localStorage.getItem("jwt");
    if (token && !this.jwtHelper.isTokenExpired(token)) {
      let role = this.jwtHelper.decodeToken(token)['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'];
      console.log(role);
      if(role==="ADMIN")
      {
      return true;
      }
    }
    else {
      return false;
    }
}
  getUserName() {
    return this.http.get(this.baseUrl + "/getUserName", {
      responseType: "text"
    });
  }
}
