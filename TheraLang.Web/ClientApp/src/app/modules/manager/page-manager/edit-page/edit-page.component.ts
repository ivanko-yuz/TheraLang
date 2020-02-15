import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormControl } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { switchMap } from 'rxjs/operators';
import { Page } from 'src/app/shared/models/page/page.model';
import { PageService } from 'src/app/core/http/manager/page.service';
import { NotificationService } from 'src/app/core/services/notification/notification.service';
import { TranslateService } from '@ngx-translate/core';
import { SlugifyPipe } from 'src/app/shared/pipes/slugify';
import { transliterate } from 'transliteration';

@Component({
  selector: 'app-edit-page',
  templateUrl: './edit-page.component.html',
  styleUrls: ['./edit-page.component.less']
})
export class EditPageComponent implements OnInit {
  page: Page;
  form = new FormGroup({
    header: new FormControl('', [Validators.required, Validators.maxLength(120)]),
    menuTitle: new FormControl('', [Validators.required, Validators.maxLength(40)]),
    content: new FormControl('', Validators.required),
    route: new FormControl(null, [Validators.maxLength(140), Validators.pattern('^[a-z0-9]+(?:-[a-z0-9]+)*$')])
  });

  constructor(
    private pageService: PageService,
    private router: Router,
    private route: ActivatedRoute,
    private notificationService: NotificationService,
    private translate: TranslateService,
    private slugifyPipe: SlugifyPipe
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
      this.form.controls.menuTitle.setValue(page.menuTitle);
      this.form.controls.route.setValue(page.route);
      this.form.controls.content.setValue(page.content);
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
      menuTitle: this.form.value.menuTitle,
      content: this.form.value.content,
      route: this.form.value.route || this.slugifyPipe.transform(transliterate(this.form.value.header))
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
