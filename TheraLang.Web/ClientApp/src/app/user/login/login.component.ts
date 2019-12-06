import { Component, OnInit } from '@angular/core';
import { NotificationService } from 'src/app/shared/services/notification.service';
import { DialogService } from 'src/app/shared/services/dialog.service';
import { NgForm } from '@angular/forms';
import { UserService } from '../user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.less']
})
export class LoginComponent implements OnInit {
  
  formModel = {
    UserName: '',
    Password: ''
  }

  constructor(private notificationService: NotificationService,
    private dialog:DialogService,
    private userService: UserService) { }

  ngOnInit() {
    // this.dialog.openFormDialog(LoginComponent);
  }

  onSubmit(form: NgForm){
    this.userService.login(form.value).subscribe(
      (res) => {
       if (res.ok){
       this.notificationService.success('Вхід успішний')
       }
      },
      (error) => {
         console.log(error);
         this.notificationService.warn('Помилка входу')
      });
    }

  onClose(){

  }
}
