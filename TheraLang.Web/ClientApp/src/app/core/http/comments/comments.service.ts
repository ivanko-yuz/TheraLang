import { Injectable } from '@angular/core';
import { baseUrl } from 'src/app/configs/api-endpoint.constants';
import { HttpClient } from '@angular/common/http';
import { PaginationParams } from 'src/app/shared/models/pagination-params/pagination-params';

@Injectable({
  providedIn: 'root'
})
export class CommentsService {

  private url = baseUrl;

  constructor(private http: HttpClient) { }

  getCommentsCount(newsId: number){
    return this.http.get(this.url + "comment/count/" + newsId);
  }

  getAllComments(newsId: number) {
    return this.http.get(this.url + "comment/all/" + newsId);
  }

  getCommentsPage(newsId: number, paginationParams: PaginationParams) {
    return this.http.get(this.url + "comment/" + newsId + "?pageNumber=" + paginationParams.pageNumber 
      + "&pageSize=" + paginationParams.pageSize);
  }

  createComment(comment) {
    return this.http.post(this.url + "comment", comment);
  }

  deleteComment(id: number) {
    return this.http.delete(this.url + "comment/" + id);
  }

  editComment(id: number, editedComment) {
    return this.http.put(this.url + "comment/" + id, editedComment);
  }
}
