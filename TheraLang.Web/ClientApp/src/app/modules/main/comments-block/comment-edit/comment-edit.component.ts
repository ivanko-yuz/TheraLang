import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { CommentView } from 'src/app/shared/models/comment/comment-view';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { CommentsService } from 'src/app/core/http/comments/comments.service';
import { TranslateService } from '@ngx-translate/core';
import { NotificationService } from 'src/app/core/services/notification/notification.service';
import { CommentRequest } from 'src/app/shared/models/comment/comment-request';

@Component({
  selector: 'app-comment-edit',
  templateUrl: './comment-edit.component.html',
  styleUrls: ['./comment-edit.component.less']
})
export class CommentEditComponent implements OnInit {

  @Input() comment: CommentView;
  @Output() edited = new EventEmitter();
  public commentForm: FormGroup;

  constructor(
    private commentsService : CommentsService,
    private translate: TranslateService,
    private notificationService: NotificationService
    ) 
    {
      this.commentForm = new FormGroup({
        "text": new FormControl("", [Validators.maxLength(10000), Validators.minLength(5)])
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

      this.commentsService.editComment(this.comment.id, formData).subscribe(
        async (msg: string) => {
          msg = await this.translate
            .get("common.updated-successfully")
            .toPromise();
          this.notificationService.success(msg);
          this.edited.emit()
        },
        async error => {
          console.log(error);
          error = await this.translate
            .get("common.wth")
            .toPromise();
          this.notificationService.warn(error);
          this.edited.emit();
        })
    }
  }

}
