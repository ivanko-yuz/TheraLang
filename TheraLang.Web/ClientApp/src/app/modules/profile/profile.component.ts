import { Component, OnInit } from "@angular/core";
import { AuthService } from "../../core/auth/auth.service";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "src/app/core/services/notification/notification.service";
import { DialogService } from "src/app/core/services/dialog/dialog.service";
import { Router, ActivatedRoute } from "@angular/router";
import {UserService} from "../../core/services/user/user.service";
import {User} from "../../shared/models/user/user";

@Component({
  selector: "app-user-profile",
  templateUrl: "./profile.component.html",
  styleUrls: ["./profile.component.less"],
})
export class ProfileComponent implements OnInit {
  user: User;

  constructor(
    private notificationService: NotificationService,
    private dialog: DialogService,
    private authService: AuthService,
    private translate: TranslateService,
    private router: Router,
    private route: ActivatedRoute,
    private userService: UserService,
  ) {}

  ngOnInit() {
    this.userService.me().subscribe((value: User) => {
      this.user = value;
    });
  }
}
