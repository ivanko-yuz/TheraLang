import { Component, OnInit } from "@angular/core";
import { AuthService } from "../../core/auth/auth.service";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "src/app/core/services/notification/notification.service";
import { DialogService } from "src/app/core/services/dialog/dialog.service";
import { Router, ActivatedRoute } from "@angular/router";



@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.less"]
})
export class LoginComponent implements OnInit {
  hide = true;
  returnUrl: string;

  constructor(
    private notificationService: NotificationService,
    private dialog: DialogService,
    public authService: AuthService,
    private translate: TranslateService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';
  }

  onSubmit() {
    this.authService.login(this.authService.loginForm.value).subscribe(response => {
      const token = (<any>response).token;
      localStorage.setItem("jwt", token);
      this.notificationService.success(this.translate
        .instant("components.account.logged-in-successfully"));
      this.router.navigateByUrl(this.returnUrl);

    }, err => {
      console.log(err);
      this.notificationService.warn(this.translate
        .instant("components.account.incorrect-login-or-password"));
    });
  }

  registration() {
    this.router.navigateByUrl("/registration");
  }

  onClose() {
    this.authService.loginForm.reset();
    this.dialog.closeDialogs();
  }
}
