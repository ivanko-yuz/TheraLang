import { Injectable } from "@angular/core";
import { commentUrl } from "src/app/configs/api-endpoint.constants";
import { HttpClient } from "@angular/common/http";
import { PaginationParams } from "src/app/shared/models/pagination-params/pagination-params";

@Injectable({
  providedIn: "root",
})
export class CommentsService {

  constructor(private http: HttpClient) { }

  getCommentsCount(newsId: number) {
    return this.http.get(`${commentUrl}/count/${newsId}`);
  }

  getAllComments(newsId: number) {
    return this.http.get(`${commentUrl}/all/${newsId}`);
  }

  getCommentsPage(newsId: number, paginationParams: PaginationParams) {
    return this.http.get(`${commentUrl}/${newsId}?pageNumber="${paginationParams.pageNumber}&pageSize=${paginationParams.pageSize}`);
  }

  createComment(comment) {
    return this.http.post(commentUrl, comment);
  }

  deleteComment(id: number) {
    return this.http.delete(`${commentUrl}/${id}`);
  }

  editComment(id: number, editedComment) {
    return this.http.put(`${commentUrl}/${id}`, editedComment);
  }
}
