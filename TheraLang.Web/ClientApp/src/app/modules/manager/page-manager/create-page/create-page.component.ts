import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators, NG_VALUE_ACCESSOR } from '@angular/forms';
import { Router } from '@angular/router';
import { Page } from 'src/app/shared/models/page/page.model';
import { PageService } from 'src/app/core/http/manager/page.service';
import { NotificationService } from 'src/app/core/services/notification/notification.service';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-create-page',
  templateUrl: './create-page.component.html',
  styleUrls: ['./create-page.component.less']
})
export class CreatePageComponent implements OnInit {

  form: FormGroup;
  page: Page;
  slugPattern = "^[a-z0-9]+(?:-[a-z0-9]+)*$";

  constructor(
    private pageService: PageService,
    private router: Router,
    private notificationService: NotificationService,
    private translate: TranslateService) {
  }

  ngOnInit() {
    this.form = new FormGroup({
      header: new FormControl(null, [Validators.required, Validators.maxLength(60)]),
      content: new FormControl(null, Validators.required),
      menuName: new FormControl(null, [Validators.required, Validators.maxLength(60)]),
      slug: new FormControl(null, [Validators.maxLength(50), Validators.pattern('^[a-z0-9]+(?:-[a-z0-9]+)*$')])
    })
  }

  onCancel() {
    this.router.navigate(['admin', 'sitemap']);
  }

  hasError(controlName: string, errorName: string) {
    return this.form.controls[controlName].hasError(errorName);
  }

  submit() {
    if (this.form.invalid) {
      return;
    }

    this.page = {
      header: this.form.value.header,
      content: this.form.value.content,
      menuName: this.form.value.menuName
    }
    
    this.pageService.addPage(this.page).subscribe(
      async (msg: string) => {
        msg = await this.translate
          .get("common.created-successfully")
          .toPromise();
        this.notificationService.success(msg);
        this.router.navigate(['admin', 'sitemap']);
      },
      async error => {
        console.log(error);
        this.notificationService.warn(
          await this.translate.get("common.wth").toPromise()
        );
      }
    );
  }
}
