import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { baseUrl } from 'src/app/configs/api-endpoint.constants';
import { NewsCreate } from 'src/app/shared/models/news/newsCreate';

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

  createNews(news){
    return this.http.post(this.url + "news",news);
  }

}