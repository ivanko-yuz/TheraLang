import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {map} from 'rxjs/operators';
import { Newpage } from 'src/app/shared/models/new_page/newpage';

@Injectable({providedIn: 'root'})
export class PageService {
  constructor(private http: HttpClient) {}

}
