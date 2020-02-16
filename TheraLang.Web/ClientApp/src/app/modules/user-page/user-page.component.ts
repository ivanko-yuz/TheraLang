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
  templateUrl: "./user-page.component.html",
  styleUrls: ["./user-page.component.less"]
})
export class UserPageComponent implements OnInit {
  userID: string;
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
    this.route.params.subscribe(params => {
      this.userID = params.userID;
    });

    this.userService.getUser(this.userID).subscribe((value: User) => {
      this.user = value;
    });
  }

  onSubmit() {
  }
}
