import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { FormBuilder, Validators } from "@angular/forms";
import { accountUrl } from "src/app/configs/api-endpoint.constants";
import { JwtHelperService } from "@auth0/angular-jwt";
@Injectable({
  providedIn: "root"
})
export class AuthService {
  constructor(
    private http: HttpClient,
    private fb: FormBuilder,
    private jwtHelper: JwtHelperService
  ) {}
  loginForm = this.fb.group({
    email: [
      "",
      [Validators.required, Validators.minLength(3), Validators.maxLength(50)]
    ],
    password: [
      "",
      [Validators.required, Validators.minLength(3), Validators.maxLength(50)]
    ]
  });
  readonly baseUrl = accountUrl;
  registrationForm = this.fb.group({
    Email: [
      "",
      [Validators.required, Validators.minLength(3), Validators.maxLength(50), Validators.email]
    ],
    Password: [
      "",
      [Validators.required, Validators.minLength(3), Validators.maxLength(50)]
    ],
    ConfirmPassword: [
      "",
      [Validators.required, Validators.minLength(3), Validators.maxLength(50)]
    ],
    FirstName: [
      "",
      [Validators.required, Validators.minLength(3), Validators.maxLength(50)]
    ],
    LastName: [
      "",
      [Validators.required, Validators.minLength(3), Validators.maxLength(50)]
    ],
    Image: [
      null,
    ]
  });
  login(loginData) {
    return this.http.post(this.baseUrl + "/login", loginData);
  }

  registration(req) {
    const formData = new FormData();
    formData.append("Email", req.Email);
    formData.append("FirstName", req.FirstName);
    formData.append("LastName", req.LastName);
    formData.append("Password", req.Password);
    formData.append("ConfirmPassword", req.ConfirmPassword);
    formData.append("Image", req.Image);
    return this.http.post(this.baseUrl + "/registration", formData);
  }

  logout() {
    localStorage.removeItem("jwt");
  }

  isAuthenticated() {
    const token: string = localStorage.getItem("jwt");
    return token && !this.jwtHelper.isTokenExpired(token);
  }

  isAdmin() {
    const token: string = localStorage.getItem("jwt");
    if (token && !this.jwtHelper.isTokenExpired(token)) {
      const role = this.jwtHelper.decodeToken(token)[
        "http://schemas.microsoft.com/ws/2008/06/identity/claims/role"
      ];
      if (role === "Admin") {
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
}
