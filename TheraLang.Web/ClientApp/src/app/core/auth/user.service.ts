import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { FormBuilder, Validators } from "@angular/forms";
import { accountUrl } from "src/app/configs/api-endpoint.constants";
@Injectable({
  providedIn: "root"
})
export class UserService {
  constructor(private http: HttpClient, private fb: FormBuilder) {}
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
    return this.http.get(this.baseUrl + "/logout");
  }
  isAuthenticated() {
    return this.http.get(this.baseUrl + "/isAuthenticated");
  }
  getUserName() {
    return this.http.get(this.baseUrl + "/getUserName", {
      responseType: "text"
    });
  }
}
