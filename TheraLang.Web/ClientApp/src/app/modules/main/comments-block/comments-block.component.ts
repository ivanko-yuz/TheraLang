import { Component, OnInit, HostListener } from '@angular/core';
import { User } from 'src/app/shared/models/user/user';
import { UserService } from 'src/app/core/services/user/user.service';
import { CommentsService } from 'src/app/core/http/comments/comments.service';
import { ActivatedRoute } from '@angular/router';
import { CommentView } from 'src/app/shared/models/comment/comment-view';
import { PaginationParams } from 'src/app/shared/models/pagination-params/pagination-params';

@Component({
  selector: 'app-comments-block',
  templateUrl: './comments-block.component.html',
  styleUrls: ['./comments-block.component.less']
})
export class CommentsBlockComponent implements OnInit {

  commentsCount : number = 0;
  currentUser: User;
  comments: CommentView[];
  newsId: number;
  maxPageCount: number
  pageSize: number = 5;
  lastPage: number = 1;
  loading: boolean = false;

  constructor
    (
      private userService: UserService,
      private commentsService: CommentsService,
      private route: ActivatedRoute
    ) { }

  ngOnInit() {
    this.newsId = parseInt(this.route.snapshot.paramMap.get("newsId"))
    this.getCurrentUser()
    this.updateComments()
  }

  getCommentsCount() {
    this.commentsService.getCommentsCount(this.newsId)
        .subscribe((count : number) => {
          this.commentsCount = count
          this.maxPageCount = Math.ceil(this.commentsCount / this.pageSize);
        })
  }

  getCurrentUser() {
    this.userService.me().subscribe(response => {
      this.currentUser = response as User
    })
  }

  getComments(){
    this.commentsService.getAllComments(this.newsId)
      .subscribe((response: CommentView[]) => {
         this.comments = response
      })
  }

  getNextCommentsPage() {
    if(this.lastPage >= this.maxPageCount) return;

    this.loading = true
    let paginationParams:PaginationParams = { pageNumber: this.lastPage + 1, pageSize : this.pageSize }
    
    this.commentsService.getCommentsPage(this.newsId, paginationParams)
      .subscribe((response: CommentView[]) => {
         this.comments.push(...response)
         this.lastPage++
         this.loading = false;
      })
  }

  updateComments(){
    this.getCommentsCount()
    
    let paginationParams: PaginationParams = {pageNumber : 1, pageSize : this.lastPage * this.pageSize}
    
    this.commentsService.getCommentsPage(this.newsId, paginationParams)
      .subscribe((response: CommentView[]) => {
         this.comments = response
      })
  }

  // TODO: fix this (now scroll event binded to window and it works with document height,
  // so if move component on top of the page it wouldn't work)
  // Make this event binded to component
  @HostListener('window:scroll', ['$event'])
  onScroll(event: any) {
    //In chrome and some browser scroll is given to body tag
    let pos = (document.documentElement.scrollTop || document.body.scrollTop) + document.documentElement.offsetHeight;
    let max = document.documentElement.scrollHeight;
    if (pos >= max - 160) {
      this.getNextCommentsPage()
    }
  }

  canLoadMore() {
    return this.lastPage < this.maxPageCount;
  }

}
