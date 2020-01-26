import { Component, OnInit, ViewChild } from "@angular/core";
import { TranslateService } from "@ngx-translate/core";
import { UserService } from "../../auth/user.service";
import { NotificationService } from "../../services/notification/notification.service";

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
    private translate: TranslateService
  ) {}

  ngOnInit() {}

  onLogout() {
    this.userService.logout()
  }
}
