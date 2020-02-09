import { Component, OnInit } from "@angular/core";
import { UserService } from "../../core/auth/user.service";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "src/app/core/services/notification/notification.service";
import { DialogService } from "src/app/core/services/dialog/dialog.service";
import { Router } from '@angular/router';



@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.less"]
})
export class LoginComponent implements OnInit {
  hide = true;
  invalidLogin: boolean;
  
  constructor(
    private notificationService: NotificationService,
    private dialog: DialogService,
    public userService: UserService,
    private translate: TranslateService,
    private router: Router
  ) {}

  ngOnInit() {}

  onSubmit() {
    this.userService.login(this.userService.loginForm.value).subscribe(response => {
      let token = (<any>response).token;
      localStorage.setItem("jwt", token);
      this.notificationService.success(this.translate
        .instant("components.account.logged-in-successfully"));
      this.router.navigate(["/"]);
  
    }, err => {
      console.log(err);
      this.notificationService.warn(this.translate
        .instant("components.account.incorrect-login-or-password"));
    });
  }

  onClose() {
    this.userService.loginForm.reset();
    this.dialog.closeDialogs();
  }
}
