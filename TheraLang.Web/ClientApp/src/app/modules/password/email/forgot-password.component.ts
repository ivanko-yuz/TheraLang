import { Component, OnInit } from "@angular/core";
import {FormBuilder, Validators} from "@angular/forms";
import {NotificationService} from "../../../core/services/notification/notification.service";
import {DialogService} from "../../../core/services/dialog/dialog.service";
import {TranslateService} from "@ngx-translate/core";
import {ActivatedRoute, Router} from "@angular/router";
import {AuthService} from "../../../core/auth/auth.service";

@Component({
  selector: "app-email-conf",
  templateUrl: "./forgot-password.component.html",
  styleUrls: ["./forgot-password.component.less"]
})
export class ForgotPasswordComponent implements OnInit {
  constructor(
    private notificationService: NotificationService,
    private dialog: DialogService,
    private translate: TranslateService,
    private router: Router,
    private route: ActivatedRoute,
    private authService: AuthService,
    private fb: FormBuilder
  ) {}

  forgotPasswordForm = this.fb.group({
    Email: [
      "",
      [Validators.required, Validators.email]
    ],
  });

  onSubmit() {
    this.authService.forgotPassword(this.forgotPasswordForm.value.Email).subscribe(() => {
      this.notificationService.success(this.translate
        // TODO: FIX ERROR MESSAGE
        .instant("components.account.password-forgot.success"));
    }, err => {
      this.notificationService.warn(this.translate
        // TODO: FIX ERROR MESSAGE
        .instant("components.account.password-forgot.error"));
    });
  }

  ngOnInit(): void {
  }
}
