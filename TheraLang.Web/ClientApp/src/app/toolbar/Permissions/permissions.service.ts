import { Injectable } from '@angular/core';
import {Observable, of, Subscription} from 'rxjs';
import {HttpClient} from '@angular/common/http';
import {baseUrl} from '../../shared/api-endpoint.constants';
import {catchError, map} from 'rxjs/operators';
import {Permissions} from './permissions.enum';

@Injectable({
  providedIn: 'root'
})
export class PermissionsService {
  public role: Permissions;
  private updating = false;

  constructor(private http: HttpClient) {
    this.updatePermissions();
  }

  private getRole(): Observable<Permissions> {
    return this.http.get<string>(`${baseUrl}account/role`)
      .pipe(
        map(role => Permissions[role]),
        catchError(err => of(Permissions.Slave))
      );
  }

  public updatePermissions(): void {
    if (this.updating) { return; }
    this.updating = true;
    const s = this.getRole().subscribe(next => {
      this.role = next;
      this.updating = false;
      s.unsubscribe();
    });
  }
}
