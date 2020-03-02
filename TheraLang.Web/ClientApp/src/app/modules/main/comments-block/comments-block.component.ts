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
  pageSize: number = 10;
  lastPage: number = 1;

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
    this.maxPageCount = Math.ceil(this.commentsCount / this.pageSize);
  }

  getCommentsCount() {
    this.commentsService.getCommentsCount(this.newsId)
        .subscribe((count : number) => this.commentsCount = count)
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
         console.log(response)
      })
  }

  getNextCommentsPage() {
    if(this.lastPage == this.maxPageCount) return;
    
    console.log(this.lastPage)
    let paginationParams:PaginationParams = { pageNumber: this.lastPage + 1, pageSize : this.pageSize }
    
    this.commentsService.getCommentsPage(this.newsId, paginationParams)
      .subscribe((response: CommentView[]) => {
         this.comments.push(...response)
         this.lastPage++
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

  @HostListener('window:scroll', ['$event'])
  onScroll(event: any) {
    //In chrome and some browser scroll is given to body tag
    let pos = (document.documentElement.scrollTop || document.body.scrollTop) + document.documentElement.offsetHeight;
    let max = document.documentElement.scrollHeight;
    if (pos == max) {
      this.getNextCommentsPage()
    }
}
}
