import { Component, OnInit } from '@angular/core';
import { NotificationService } from 'src/app/shared/services/notification.service';
import { DialogService } from 'src/app/shared/services/dialog.service';
import { UserService } from '../user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.less']
})
export class LoginComponent implements OnInit {

  hide = true;

  constructor(private notificationService: NotificationService,
    private dialog:DialogService,
    public userService: UserService) { }

  ngOnInit() {
  }

    onSubmit() {
    this.userService.login(this.userService.loginForm.value).subscribe(
      (msg:string) => {
        msg = 'Вхід успішний';
        this.notificationService.success(msg);
        this.onClose();
      },
      (error) => {
        console.log(error);
        this.notificationService.warn('Неправильний логін або пароль')
        this.userService.loginForm.reset();
      });

  }

  onClose() {
    this.userService.loginForm.reset();
    this.dialog.closeDialogs();
  }

}
