import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormGroup, Validators, FormControl } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { switchMap } from 'rxjs/operators';
import { Page } from 'src/app/shared/models/page/page.model';
import { PageService } from 'src/app/core/http/manager/page.service';
import { NotificationService } from 'src/app/core/services/notification/notification.service';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-edit-page',
  templateUrl: './edit-page.component.html',
  styleUrls: ['./edit-page.component.less']
})
export class EditPageComponent implements OnInit {
  page: Page;
  form = new FormGroup({
    header: new FormControl('', [Validators.required, Validators.maxLength(60)]),
    menuName: new FormControl('', [Validators.required, Validators.maxLength(60)]),
    content: new FormControl('', Validators.required)
  });

  constructor(
    private pageService: PageService,
    private router: Router,
    private route: ActivatedRoute,
    private notificationService: NotificationService,
    private translate: TranslateService
  ) {
  }

  ngOnInit() {
    this.route.params.pipe(
      switchMap((params: Params) => {
        return this.pageService.getPageById(params['id']);
      })
    ).subscribe((page: Page) => {
      this.page = page
      this.form.controls.header.setValue(page.header);
      this.form.controls.content.setValue(page.content);
      this.form.controls.menuName.setValue(page.menuName);
    });
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

    this.pageService.updatePage({
      ...this.page,
      header: this.form.value.header,
      menuName: this.form.value.menuName,
      content: this.form.value.content
    }).subscribe(
      async (msg: string) => {
        msg = await this.translate.get("common.updated-successfully").toPromise();
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
