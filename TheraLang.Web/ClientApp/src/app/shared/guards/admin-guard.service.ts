import { Injectable } from '@angular/core';
import { CanActivate, Router, RouterStateSnapshot, ActivatedRouteSnapshot } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Roles } from 'src/app/shared/models/roles/roles';

@Injectable()
export class AdminGuard implements CanActivate {

  constructor(private jwtHelper: JwtHelperService, private router: Router) {
  }
  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    const token = localStorage.getItem("jwt");

    if (token && !this.jwtHelper.isTokenExpired(token)) {
      const jwtData = this.jwtHelper.decodeToken(token);
      const role = jwtData["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"];
      if (role === Roles.Admin) {
        return true;
      }
    }
    this.router.navigate(["login"], { queryParams: { returnUrl: state.url } });
    return false;
  }

}
