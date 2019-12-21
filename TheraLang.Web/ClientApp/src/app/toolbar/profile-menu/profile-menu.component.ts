import { Component, OnInit, ViewChild } from '@angular/core';
import { UserService } from 'src/app/user/user.service';
import { NotificationService } from 'src/app/shared/services/notification.service';

@Component({
  selector: 'app-profile-menu',
  templateUrl: './profile-menu.component.html',
  styleUrls: ['./profile-menu.component.less']
})
export class ProfileMenuComponent implements OnInit {

  @ViewChild('menu', {static: true}) menu;

  constructor(
    private userService: UserService,
    private notification: NotificationService
  ) { }

  ngOnInit() {
  }

  onLogout() {
    this.userService.logout().subscribe(
      (msg: string) => {
        msg = 'Ви вийшли з облікового запису';
        this.notification.success(msg);
      },
      (error) => {
        console.log(error);
        this.notification.warn('Помилка');
      });
    }
}
