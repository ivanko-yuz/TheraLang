import { Component, OnInit, ViewChild } from '@angular/core';
import { UserService } from 'src/app/user/user.service';
import { NotificationService } from 'src/app/shared/services/notification.service';
import {TranslateService} from '@ngx-translate/core';

@Component({
  selector: 'app-profile-menu',
  templateUrl: './profile-menu.component.html',
  styleUrls: ['./profile-menu.component.less']
})
export class ProfileMenuComponent implements OnInit {

  @ViewChild('menu', {static: true}) menu;

  constructor(
    private userService: UserService,
    private notification: NotificationService,
    private translate: TranslateService
  ) { }

  ngOnInit() {
  }

  onLogout() {
    this.userService.logout().subscribe(
      async (msg: string) => {
        msg = await this.translate.get('components.account.logged-out-successfully').toPromise();
        this.notification.success(msg);
      },
      async (error) => {
        console.log(error);
        const msg = await this.translate.get('common.error').toPromise();
        this.notification.warn(msg);
      });
    }
}
