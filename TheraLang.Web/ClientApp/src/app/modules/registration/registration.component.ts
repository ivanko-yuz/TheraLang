import { Component, OnInit } from "@angular/core";
import { AuthService } from "../../core/auth/auth.service";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "src/app/core/services/notification/notification.service";
import { DialogService } from "src/app/core/services/dialog/dialog.service";
import { Router, ActivatedRoute } from "@angular/router";



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
    private authService: AuthService,
    private translate: TranslateService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.returnUrl = this.route.snapshot.queryParams.returnUrl || "/";
  }

  onSubmit() {
    this.authService.registration(this.authService.registrationForm.value).subscribe(value => {
      this.router.navigateByUrl("/login");
      this.notificationService.success(this.translate
        .instant("components.account.successfully-registration"));
    }, err => {
      this.notificationService.warn(this.translate
        .instant("components.account.error"));
    });
  }

  onClose() {
    this.authService.loginForm.reset();
    this.dialog.closeDialogs();
  }

  onFileChange(event) {
    if (event.target.files && event.target.files.length) {
      const [file] = event.target.files;
      console.log(file);

      this.authService.registrationForm.patchValue({
        Image: file,
      });
    }
  }
}
