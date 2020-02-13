import { Component, OnInit, ViewChild } from "@angular/core";
import { TranslateService } from "@ngx-translate/core";
import { UserService } from "../../../../core/auth/user.service";
import { NotificationService } from "../../../../core/services/notification/notification.service";
import {Router} from '@angular/router';

@Component({
  selector: "app-profile-menu",
  templateUrl: "./profile-menu.component.html",
  styleUrls: ["./profile-menu.component.less"]
})
export class ProfileMenuComponent implements OnInit {
  @ViewChild("menu", { static: true }) menu;

  constructor(
    private userService: UserService,
    private notification: NotificationService,
    private translate: TranslateService,
    private router: Router
  ) {}

  ngOnInit() {}

  onLogout() {
    this.userService.logout();
    this.router.navigate(["/"]);
  }
}
