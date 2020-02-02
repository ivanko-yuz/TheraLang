import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable()
export class AdminGuard implements CanActivate {

  constructor(private jwtHelper: JwtHelperService, private router: Router) {
  }
  canActivate() {
    var token = localStorage.getItem("jwt");

    if (token && !this.jwtHelper.isTokenExpired(token)){
      let jwtData = this.jwtHelper.decodeToken(token);
      let role = jwtData['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'];
     // console.log(role);
      if(role==="ADMIN")
      {
      return true;
      }
    }
    this.router.navigate(["login"]);
    return false;
  }

}
