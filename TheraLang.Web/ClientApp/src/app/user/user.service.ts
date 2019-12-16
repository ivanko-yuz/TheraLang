import { Injectable } from '@angular/core';
import { accountUrl } from '../shared/api-endpoint.constants';
import { HttpClient} from '@angular/common/http';
import { FormBuilder, Validators } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(
    private http: HttpClient,
    private fb: FormBuilder
  ) { }

  loginForm = this.fb.group({
    username: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
    password: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
  });

  readonly baseUrl = accountUrl;

  login(loginData) {
    return this.http.post(this.baseUrl + '/login', loginData);
  }
  
  logout(){
    return this.http.get(this.baseUrl + '/logout');
  }

  test(){
    return this.http.get(this.baseUrl + '/getUserId').subscribe(
      (msg) => {
        console.log(msg)
       },
    )
  }
}
