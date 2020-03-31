import { Component, OnInit, Input, Output, EventEmitter, ComponentFactoryResolver, ViewContainerRef, ViewChild } from "@angular/core";
import { CommentView } from "src/app/shared/models/comment/comment-view";
import { CommentsService } from "src/app/core/http/comments/comments.service";
import { DialogService } from "src/app/core/services/dialog/dialog.service";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "src/app/core/services/notification/notification.service";
import { CommentEditComponent } from "../comment-edit/comment-edit.component";
import { UserService } from "src/app/core/auth/user.service";
import { Roles } from "src/app/shared/models/roles/roles";

@Component({
  selector: "app-comment",
  templateUrl: "./comment.component.html",
  styleUrls: ["./comment.component.less"],
})
export class CommentComponent implements OnInit {
  @ViewChild("container", {read: ViewContainerRef, static: true}) container: ViewContainerRef;

  @Input() comment: CommentView;
  @Output() commentChanged = new EventEmitter();
  smallTextSize = 400;
  textSize: number = this.smallTextSize;
  isOpened = false;
  isEditing = false;

  constructor
  (
      private commentsService: CommentsService,
      private dialogService: DialogService,
      private translate: TranslateService,
      private notificationService: NotificationService,
      private componentFactoryResolver: ComponentFactoryResolver,
      private userService: UserService,
    ) { }

  ngOnInit() {
  }

  isOwner() {
    return this.comment.createdById === this.userService.getCurrentUserId();
  }

  isAdmin() {
    return this.userService.isRole(Roles.Admin);
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
            this.commentChanged.emit();
            this.notificationService.success(await this.translate.get("common.deleted-successfully").toPromise());
          });
        }
      },
      async error => {
        console.log(error);
        error = await this.translate
            .get("common.wth")
            .toPromise();
        this.notificationService.warn(error);
      },
      );
  }

  onEdit() {
    this.isEditing = true;
    this.container.clear();
    const factory = this.componentFactoryResolver.resolveComponentFactory(CommentEditComponent);
    const editComponent: any = this.container.createComponent(factory);
    editComponent.instance.comment = this.comment;
    editComponent.instance.edited.subscribe(event => {
      this.isEditing = false;
      this.container.clear();
      this.comment.isEdited = true;
    });
  }
}
