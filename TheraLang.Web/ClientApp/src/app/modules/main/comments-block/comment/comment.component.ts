import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { CommentView } from 'src/app/shared/models/comment/comment-view';
import { CommentsService } from 'src/app/core/http/comments/comments.service';
import { DialogService } from 'src/app/core/services/dialog/dialog.service';
import { TranslateService } from '@ngx-translate/core';
import { NotificationService } from 'src/app/core/services/notification/notification.service';

@Component({
  selector: 'app-comment',
  templateUrl: './comment.component.html',
  styleUrls: ['./comment.component.less']
})
export class CommentComponent implements OnInit {

  @Input() comment: CommentView;
  @Output() commentChanged = new EventEmitter();
  smallTextSize: number = 500;
  textSize: number = this.smallTextSize;
  isOpened: boolean = false;

  constructor
    (
      private commentsService: CommentsService,
      private dialogService: DialogService,
      private translate: TranslateService,
      private notificationService: NotificationService
    ) { }

  ngOnInit() {
  }

  isFull() {
    return this.comment.text.length <= this.textSize;
  }

  showFullComment() {
    this.textSize = this.comment.text.length;
    this.isOpened = true;
  }

  showSmallComment() {
    this.textSize = this.smallTextSize;
    this.isOpened = false;
  }

  async onDelete() {
    this.dialogService
      .openConfirmDialog(await this.translate.get("common.r-u-sure").toPromise())
      .afterClosed()
      .subscribe(async res => {
        if (res) {
          this.commentsService.deleteComment(this.comment.id).subscribe(async result => {
            this.notificationService.success(await this.translate.get("common.deleted-successfully").toPromise());
            this.commentChanged.emit("");
          });
        }
      });
  }

  onEdit() {
    // this.commentsService.editComment(this.comment.id).subscribe();
  }
}
