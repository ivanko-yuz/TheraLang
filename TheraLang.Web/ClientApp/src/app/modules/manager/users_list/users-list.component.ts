import {Component, OnInit, Output} from "@angular/core";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "src/app/core/services/notification/notification.service";
import { Router, ActivatedRoute } from "@angular/router";
import {ChangeRoleComponent} from "./change-role/change-role.component";
import {MatDialog} from "@angular/material";
import { UserService } from "src/app/core/services/user/user.service";
import { Role } from "src/app/shared/models/role/role";
import { User, UserPageViewModel } from "src/app/shared/models/user/user";
import {BreakpointObserver, Breakpoints} from "@angular/cdk/layout";

@Component({
  selector: "app-user-profile",
  templateUrl: "./users-list.component.html",
  styleUrls: ["./users-list.component.less"],
})

export class UsersListComponent implements OnInit {
  returnUrl: string;
  usersList: UserPageViewModel;
  pageSize = 12;
  private breakpoint: number;
  public isMobile = false;
  constructor(
    breakpointObserver: BreakpointObserver,
    private notificationService: NotificationService,
    private dialog: MatDialog,
    private userService: UserService,
    private translate: TranslateService,
    private router: Router,
    private route: ActivatedRoute,
  ) {
    breakpointObserver.observe([
      Breakpoints.Handset,
    ]).subscribe(result => {
      this.isMobile = result.matches;
    });
  }

  ngOnInit() {
    this.returnUrl = this.route.snapshot.queryParams.returnUrl || "/";
    this.userService.list(this.pageSize, 1).subscribe((value: UserPageViewModel) => {
      this.usersList = value;
      this.breakpoint = (window.innerWidth <= 400) ? 1 : 3;
    });
  }

  onResize(event) {
    this.breakpoint = (event.target.innerWidth <= 400) ? 1 : 3;
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
            width: "514px",
            height: "313",
            data: {
              rolesList: roles,
              userRoleId: value.id,
            },
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
