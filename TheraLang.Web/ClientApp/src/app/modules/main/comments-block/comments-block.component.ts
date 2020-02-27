import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/shared/models/user/user';
import { UserService } from 'src/app/core/services/user/user.service';
import { CommentsService } from 'src/app/core/http/comments/comments.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-comments-block',
  templateUrl: './comments-block.component.html',
  styleUrls: ['./comments-block.component.less']
})
export class CommentsBlockComponent implements OnInit {

  commentsCount : number = 0;
  currentUser: User;
  comments: Comment[];
  newsId: number;

  constructor
    (
      private userService: UserService,
      private commentsService: CommentsService,
      private route: ActivatedRoute
    ) { }

  ngOnInit() {
    this.newsId = parseInt(this.route.snapshot.paramMap.get("newsId"))
    this.getCommentsCount(this.newsId)
    this.getCurrentUser()
    this.getComments(this.newsId)
  }

  getCommentsCount(newsId : number) {
    this.commentsService.getCommentsCount(newsId)
        .subscribe((count : number) => this.commentsCount = count)
  }

  getCurrentUser() {
    this.userService.me().subscribe(response => {
      this.currentUser = response as User
    })
  }

  getComments(newsId: number){
    this.commentsService.getAllComments(newsId)
      .subscribe((response: Comment[]) => {
         this.comments = response
         console.log(response)
      })
  }

  updateComment(event){
    this.getComments(this.newsId);
  }
}
