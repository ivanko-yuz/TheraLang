import { Component, OnInit } from "@angular/core";
import { UserService } from "../../core/auth/user.service";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "src/app/core/services/notification/notification.service";
import { DialogService } from "src/app/core/services/dialog/dialog.service";
import { Router, ActivatedRoute } from '@angular/router';



@Component({
  selector: "app-registration",
  templateUrl: "./registration.component.html",
  styleUrls: ["./registration.component.less"]
})
export class RegistrationComponent implements OnInit {
  hide = true;
  returnUrl: string;

  constructor(
    private notificationService: NotificationService,
    private dialog: DialogService,
    private userService: UserService,
    private translate: TranslateService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';
  }

  onSubmit() {
    // this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';
    this.userService.registration(this.userService.registrationForm.value).subscribe(value => {
      this.router.navigateByUrl("/login");
      this.notificationService.success(this.translate
        .instant("components.account.successfully-registration"));
    }, err => {
      this.notificationService.warn(this.translate
        .instant("components.account.error"));
    });
  }

  onClose() {
    this.userService.loginForm.reset();
    this.dialog.closeDialogs();
  }
}
