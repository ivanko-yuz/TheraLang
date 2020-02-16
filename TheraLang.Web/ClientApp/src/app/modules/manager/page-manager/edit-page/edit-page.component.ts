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
  page_eng: Page;
  pages: Page[];
  routeUrl: string;
  form = new FormGroup({
    header: new FormControl('', [Validators.required, Validators.maxLength(120)]),
    menuTitle: new FormControl('', [Validators.required, Validators.maxLength(40)]),
    content: new FormControl('', Validators.required),

    header_eng: new FormControl('', [Validators.maxLength(120)]),
    menuTitle_eng: new FormControl('', [Validators.maxLength(40)]),
    content_eng: new FormControl(),

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
    this.fetchData();
    this.routeUrl = this.route.snapshot.paramMap.get('route');
  }

  fetchData() {
    this.route.params.pipe(
      switchMap((params: Params) => {
        return this.pageService.getPagesByRoute(params['route']);
      })
    ).subscribe((pages: Page[]) => {
      this.pages = pages
      this.form.controls.header.setValue(pages[0].header);
      this.form.controls.menuTitle.setValue(pages[0].menuTitle);
      this.form.controls.content.setValue(pages[0].content);

      this.form.controls.header_eng.setValue(pages[1].header);
      this.form.controls.menuTitle_eng.setValue(pages[1].menuTitle);
      this.form.controls.content_eng.setValue(pages[1].content);

      this.form.controls.route.setValue(pages[0].route);
    });
  }

  onCancel() {
    this.router.navigate(['admin', 'sitemap']);
  }

  hasError(controlName: string, errorName: string) {
    return this.form.controls[controlName].hasError(errorName);
  }

  updatePages(pages: Page[]) {
    this.pageService.updatePages(pages, this.routeUrl).subscribe(
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

  submit() {
    if (this.form.invalid) {
      return;
    }

    this.page = {
      ...this.page,
      header: this.form.value.header,
      content: this.form.value.content,
      menuTitle: this.form.value.menuTitle,
      route: this.form.value.route || this.slugifyPipe.transform(transliterate(this.form.value.header))
    }

    this.page_eng = {
      ...this.page_eng,
      header: this.form.value.header_eng,
      content: this.form.value.content_eng,
      menuTitle: this.form.value.menuTitle_eng,
      route: this.form.value.route || this.slugifyPipe.transform(transliterate(this.form.value.header))
    }

    if (this.page_eng.header && this.page_eng.menuTitle && this.page_eng.content) {
      this.updatePages([this.page, this.page_eng]);
    } else {
      this.updatePages([this.page]);
    }
  }
}
