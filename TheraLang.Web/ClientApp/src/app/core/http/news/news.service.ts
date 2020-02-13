import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { baseUrl } from 'src/app/configs/api-endpoint.constants';

@Injectable({
  providedIn: 'root'
})
export class NewsService {

  constructor(private http: HttpClient) { }

  private url = baseUrl;

  getAllNews(){
    return this.http.get(this.url+"news/all");
  }

  getNewsById(id: number){
    return this.http.get(this.url+"news/"+id);
  }

  

}
