import { Injectable } from '@angular/core';
import { accountUrl } from '../shared/api-endpoint.constants';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(
    private http: HttpClient
  ) { }

  readonly baseUrl = accountUrl;

  login(formData) {
    return this.http.post(this.baseUrl + '/login', formData, {observe: 'response'});
  }
}
