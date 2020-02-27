import { Component, OnInit, Input } from '@angular/core';
import { UserService } from 'src/app/core/services/user/user.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { User } from 'src/app/shared/models/user/user';
import { CommentsService } from 'src/app/core/http/comments/comments.service';
import { TranslateService } from '@ngx-translate/core';
import { NotificationService } from 'src/app/core/services/notification/notification.service';
import { CommentCreate } from 'src/app/shared/models/comment/comment-create';

@Component({
  selector: 'app-comment-create',
  templateUrl: './comment-create.component.html',
  styleUrls: ['./comment-create.component.less']
})
export class CommentCreateComponent implements OnInit {

  @Input() currentUser: User;
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
      const comment = this.commentForm.value as CommentCreate;
      formData.append("text", comment.text);

      this.commentsService.createComment(formData).subscribe(
        async (msg: string) => {
          msg = await this.translate
            .get("common.created-successfully")
            .toPromise();
          this.notificationService.success(msg);
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
