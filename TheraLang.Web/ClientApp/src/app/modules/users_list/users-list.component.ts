import {Component, OnInit, Output} from '@angular/core';
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "src/app/core/services/notification/notification.service";
import { Router, ActivatedRoute } from "@angular/router";
import {UserService} from "../../core/services/user/user.service";
import {User, UserPageViewModel} from '../../shared/models/user/user';
import {ChangeRoleComponent} from "./change-role/change-role.component";
import {MatDialog} from "@angular/material";
import {Role} from "../../shared/models/role/role";

@Component({
  selector: "app-user-profile",
  templateUrl: "./users-list.component.html",
  styleUrls: ["./users-list.component.less"]
})
export class UsersListComponent implements OnInit {
  returnUrl: string;
  usersList: UserPageViewModel;
  pageSize = 10;

  constructor(
    private notificationService: NotificationService,
    private dialog: MatDialog,
    private userService: UserService,
    private translate: TranslateService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.returnUrl = this.route.snapshot.queryParams.returnUrl || "/";
    this.userService.list(this.pageSize, 1).subscribe((value: UserPageViewModel) => {
      this.usersList = value;
    });
  }

  pageChange(event) {
    this.userService.list(this.pageSize, event).subscribe((value: UserPageViewModel) => {
      this.usersList = value;
    });
  }

  openChangeRoleModal(userID) {
    this.userService.getRole(userID).subscribe(
      (value: Role) => {
        this.userService.getRoles().subscribe((roles: Role[]) => {
          const dialog = this.dialog.open(ChangeRoleComponent, {
            width: "400px",
            data: {
              rolesList: roles,
              userRoleId: value.id,
            }
          });
          dialog.afterClosed().subscribe(result => {
            if (result === undefined) {
              return;
            }

            this.userService.changeRole(userID, result).subscribe(() => {
              window.location.reload();
            });
          });
        });
      },
    );
  }
}
