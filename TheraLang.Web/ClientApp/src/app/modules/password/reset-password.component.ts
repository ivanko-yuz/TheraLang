import { Component, OnInit } from "@angular/core";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "src/app/core/services/notification/notification.service";
import { DialogService } from "src/app/core/services/dialog/dialog.service";
import { Router, ActivatedRoute } from "@angular/router";
import {FormBuilder, Validators} from "@angular/forms";
import {AuthService} from "../../core/auth/auth.service";
@Component({
  selector: "app-reset-password",
  templateUrl: "./reset-password.component.html",
  styleUrls: ["./reset-password.component.less"]
})
export class ResetPasswordComponent implements OnInit {
  confirmed: boolean;
  hide = true;
  code: number;
  email: string;

  constructor(
    private notificationService: NotificationService,
    private dialog: DialogService,
    private translate: TranslateService,
    private router: Router,
    private route: ActivatedRoute,
    private authService: AuthService,
    private fb: FormBuilder
  ) {}

  confirmPasswordForm = this.fb.group({
    Password: [
      "",
      [Validators.required, Validators.minLength(4), Validators.maxLength(50)]
    ],
    ConfirmPassword: [
      "",
      [Validators.required, Validators.minLength(4), Validators.maxLength(50)]
    ]
  });

  ngOnInit() {
    this.confirmed = false;
    this.route.queryParams.subscribe(query => {
      this.email = query.email;
      // tslint:disable-next-line:variable-name
      this.code = query.number;
    });
  }

  onSubmit() {
    this.authService.resetPassword(
      this.confirmPasswordForm.value.Password,
      this.confirmPasswordForm.value.ConfirmPassword,
      this.email,
      this.code
    ).subscribe(() => {
      this.router.navigateByUrl("/login");
    }, err => {
      this.notificationService.warn(this.translate
        .instant("components.account.password-reset.error"));
    });
  }
}
