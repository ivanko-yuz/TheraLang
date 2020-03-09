import { Injectable } from "@angular/core";
import {HttpClient, HttpParams} from '@angular/common/http';
import { FormBuilder, Validators } from "@angular/forms";
import {accountUrl, userUrl} from "src/app/configs/api-endpoint.constants";
import { JwtHelperService } from "@auth0/angular-jwt";
import {User} from '../../../shared/models/user/user';
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

  list(pageSize, pageNumber) {
    const params = new HttpParams().
    set("PageSize", pageSize).
    set("PageNumber", pageNumber);
    return this.http.get(this.baseUrl, {
      params,
    });
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
  editProfile(value) {
    const formData = new FormData();
    if (value.BirthDay !== "") {
      const date = new Date(value.BirthDay);
      formData.append("BirthDay", date.toDateString());
    }
    formData.append("FirstName", value.FirstName);
    formData.append("LastName", value.LastName);
    formData.append("Image", value.Image);
    formData.append("City", value.City);
    formData.append("ShortInformation", value.ShortInformation);
    formData.append("PhoneNumber", value.PhoneNumber);

    return this.http.put(this.baseUrl, formData);
  }
}
