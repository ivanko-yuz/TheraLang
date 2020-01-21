import { Component, OnInit } from "@angular/core";
import { UserService } from "../../../../core/auth/user.service";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "src/app/core/services/notification/notification.service";
import { DialogService } from "src/app/core/services/dialog/dialog.service";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.less"]
})
export class LoginComponent implements OnInit {
  hide = true;

  constructor(
    private notificationService: NotificationService,
    private dialog: DialogService,
    public userService: UserService,
    private translate: TranslateService
  ) {}

  ngOnInit() {}

  onSubmit() {
    this.userService.login(this.userService.loginForm.value).subscribe(
      async (msg: string) => {
        msg = await this.translate
          .get("components.account.logged-in-successfully")
          .toPromise();
        this.notificationService.success(msg);
        this.onClose();
      },
      async error => {
        console.log(error);
        this.notificationService.warn(
          await this.translate
            .get("components.account.incorrect-login-or-password")
            .toPromise()
        );
        this.userService.loginForm.reset();
      }
    );
  }

  onClose() {
    this.userService.loginForm.reset();
    this.dialog.closeDialogs();
  }
}
