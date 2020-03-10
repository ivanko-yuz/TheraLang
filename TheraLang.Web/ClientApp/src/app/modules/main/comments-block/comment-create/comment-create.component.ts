import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { User } from 'src/app/shared/models/user/user';
import { CommentsService } from 'src/app/core/http/comments/comments.service';
import { TranslateService } from '@ngx-translate/core';
import { NotificationService } from 'src/app/core/services/notification/notification.service';
import { CommentRequest } from 'src/app/shared/models/comment/comment-request';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-comment-create',
  templateUrl: './comment-create.component.html',
  styleUrls: ['./comment-create.component.less']
})
export class CommentCreateComponent implements OnInit {

  @Input() currentUser: User;
  @Output() commentCreated = new EventEmitter();
  public commentForm: FormGroup;
  commentText: string;

  constructor(
    private commentsService : CommentsService,
    private translate: TranslateService,
    private notificationService: NotificationService,
    private route: ActivatedRoute
    ) 
    {
      this.commentForm = new FormGroup({
        "text": new FormControl(null, [Validators.maxLength(10000), Validators.minLength(1)]),
    });
  }

  ngOnInit() {
  }

  onSubmit() {
    if (this.commentForm.invalid) {
      const controls = this.commentForm.controls;
      Object.keys(controls).forEach(controlName =>
        controls[controlName].markAsTouched()
      );
      return;
    }
    else {
      const formData = new FormData();
      let comment = this.commentForm.value as CommentRequest;
      formData.append("text", comment.text);
      comment.newsId = parseInt(this.route.snapshot.paramMap.get("newsId"))
      formData.append("newsId", comment.newsId.toString());

      this.commentsService.createComment(formData).subscribe(
        async (msg: string) => {
          msg = await this.translate
            .get("common.created-successfully")
            .toPromise();
          this.commentForm.reset();
          this.notificationService.success(msg);
          this.commentCreated.emit();
        },
        async error => {
          console.log(error);
          this.notificationService.warn(
            await this.translate.get("common.wth").toPromise()
          );
        })
    }
  }
}
