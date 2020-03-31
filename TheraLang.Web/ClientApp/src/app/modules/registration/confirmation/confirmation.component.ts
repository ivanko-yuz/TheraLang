import { Component, OnInit } from "@angular/core";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "src/app/core/services/notification/notification.service";
import { DialogService } from "src/app/core/services/dialog/dialog.service";
import { Router, ActivatedRoute } from "@angular/router";
import {AuthService} from "../../../core/auth/auth.service";
@Component({
  selector: "app-confirmation",
  templateUrl: "./confirmation.component.html",
  styleUrls: ["./confirmation.component.less"],
})
export class ConfirmationComponent implements OnInit {
  confirmed: boolean;

  constructor(
    private notificationService: NotificationService,
    private dialog: DialogService,
    private translate: TranslateService,
    private router: Router,
    private route: ActivatedRoute,
    private authService: AuthService,
  ) {}

  ngOnInit() {
    this.confirmed = false;
    this.route.queryParams.subscribe(query => {
      const email = query.email;
      // tslint:disable-next-line:variable-name
      const number: number = query.number;
      this.authService.confirmUser(number, email).subscribe(() => {
        this.confirmed = true;
      });
    });
  }
}
