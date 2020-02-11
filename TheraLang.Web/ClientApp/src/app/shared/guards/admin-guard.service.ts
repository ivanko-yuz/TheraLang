import { Injectable } from '@angular/core';
import { CanActivate, Router, RouterStateSnapshot, ActivatedRouteSnapshot } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable()
export class AdminGuard implements CanActivate {

  constructor(private jwtHelper: JwtHelperService, private router: Router) {
  }
  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    var token = localStorage.getItem("jwt");

    if (token && !this.jwtHelper.isTokenExpired(token)) {
      let jwtData = this.jwtHelper.decodeToken(token);
      let role = jwtData['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'];

      if (role === "ADMIN") {
        return true;
      }
    }
    this.router.navigate(["login"], { queryParams: { returnUrl: state.url } });
    return false;
  }

}
