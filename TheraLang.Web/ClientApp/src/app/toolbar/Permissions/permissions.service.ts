import { Injectable } from '@angular/core';
import {Observable} from 'rxjs';
import {HttpClient} from '@angular/common/http';
import {baseUrl} from '../../shared/api-endpoint.constants';
import {Permissions} from './permissions.enum';
import {log} from 'util';

@Injectable({
  providedIn: 'root'
})
export class PermissionsService {
  public role: Permissions;
  private updating = false;

  constructor(private http: HttpClient) {
    this.updatePermissions();
  }

  private getRole(): Observable<string> {
    return this.http.get<string>(`${baseUrl}account/role`, { responseType: 'text' });
  }

  public updatePermissions(): void {
    if (this.updating) { return; }
    this.updating = true;
    const s = this.getRole().subscribe(next => {
      this.role = Permissions[next];
      this.updating = false;
      s.unsubscribe();
    }, log());
  }
}
