import { Component, OnInit, HostListener } from "@angular/core";
import { User } from "src/app/shared/models/user/user";
import { UserService } from "src/app/core/services/user/user.service";
import { CommentsService } from "src/app/core/http/comments/comments.service";
import { ActivatedRoute } from "@angular/router";
import { CommentView } from "src/app/shared/models/comment/comment-view";
import { PaginationParams } from "src/app/shared/models/pagination-params/pagination-params";
import { delay } from "rxjs/operators";

@Component({
  selector: "app-comments-block",
  templateUrl: "./comments-block.component.html",
  styleUrls: ["./comments-block.component.less"],
})
export class CommentsBlockComponent implements OnInit {

  commentsCount = 0;
  currentUser: User;
  comments: CommentView[];
  newsId: number;
  maxPageCount: number;
  pageSize = 10;
  lastPage = 1;
  loading = false;

  constructor
  (
      private userService: UserService,
      private commentsService: CommentsService,
      private route: ActivatedRoute,
    ) { }

  ngOnInit() {
    this.newsId = parseInt(this.route.snapshot.paramMap.get("newsId"));
    this.getCurrentUser();
    this.updateComments();
  }

  getCommentsCount() {
    this.commentsService.getCommentsCount(this.newsId)
        .subscribe((count: number) => {
          this.commentsCount = count;
          this.maxPageCount = Math.ceil(this.commentsCount / this.pageSize);
        });
  }

  getCurrentUser() {
    this.userService.me().subscribe(response => {
      this.currentUser = response as User;
    });
  }

  getNextCommentsPage() {
    if (this.lastPage >= this.maxPageCount) return;
    if (this.loading) return;

    this.loading = true;
    const paginationParams: PaginationParams = { pageNumber: this.lastPage + 1, pageSize : this.pageSize };

    this.commentsService.getCommentsPage(this.newsId, paginationParams)
      .pipe(delay(100))
      .subscribe((response: CommentView[]) => {
         this.comments.push(...response);
         this.lastPage++;
         this.loading = false;
      },
      error => {
        this.loading = false;
      });
  }

  updateComments() {
    this.getCommentsCount();

    const paginationParams: PaginationParams = {pageNumber : 1, pageSize : this.lastPage * this.pageSize};

    this.commentsService.getCommentsPage(this.newsId, paginationParams)
      .subscribe((response: CommentView[]) => {
         this.comments = response;
      });
  }

  onScroll() {
    this.getNextCommentsPage();
  }

  isLoading() {
    return this.loading;
  }

}
