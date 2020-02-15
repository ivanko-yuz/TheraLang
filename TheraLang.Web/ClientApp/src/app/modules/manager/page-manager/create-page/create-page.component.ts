import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Page } from 'src/app/shared/models/page/page.model';
import { PageService } from 'src/app/core/http/manager/page.service';
import { NotificationService } from 'src/app/core/services/notification/notification.service';
import { TranslateService } from '@ngx-translate/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { SlugifyPipe } from 'src/app/shared/pipes/slugify';
import { transliterate } from 'transliteration';
import { Language } from 'src/app/shared/models/language/languages.enum';

@Component({
  selector: 'app-create-page',
  templateUrl: './create-page.component.html',
  styleUrls: ['./create-page.component.less']
})
export class CreatePageComponent implements OnInit {

  form: FormGroup;
  page: Page;
  page_eng: Page;

  constructor(
    private pageService: PageService,
    private router: Router,
    private notificationService: NotificationService,
    private translate: TranslateService,
    private slugifyPipe: SlugifyPipe) {
  }

  ngOnInit() {
    this.form = new FormGroup({
      header: new FormControl(null, [Validators.required, Validators.maxLength(120)]),
      content: new FormControl(null, Validators.required),
      menuTitle: new FormControl(null, [Validators.required, Validators.maxLength(40)]),

      header_eng: new FormControl(null, [Validators.maxLength(120)]),
      content_eng: new FormControl(),
      menuTitle_eng: new FormControl(null, [Validators.maxLength(40)]),

      route: new FormControl(null, [Validators.maxLength(140), Validators.pattern('^[a-z0-9]+(?:-[a-z0-9]+)*$')])
    })
  }

  onCancel() {
    this.router.navigate(['admin', 'sitemap']);
  }

  hasError(controlName: string, errorName: string) {
    return this.form.controls[controlName].hasError(errorName);
  }

  async createPage(page: Page) {
    this.pageService.addPage(page).subscribe(async (msg: string) => {
      msg = await this.translate
        .get("common.created-successfully")
        .toPromise();
      this.notificationService.success(msg);
      this.router.navigate(['admin', 'sitemap']);
    }, async (error) => {
      console.log(error);
      this.notificationService.warn(await this.translate.get("common.wth").toPromise());
    });
  }

  async submit() {
    if (this.form.invalid) {
      return;
    }

    this.page = {
      header: this.form.value.header,
      content: this.form.value.content,
      menuTitle: this.form.value.menuTitle,
      route: this.form.value.route || this.slugifyPipe.transform(transliterate(this.form.value.header)),
      language: Language.Ukrainian
    }

    this.page_eng = {
      header: this.form.value.header_eng,
      content: this.form.value.content_eng,
      menuTitle: this.form.value.menuTitle_eng,
      route: this.form.value.route || this.slugifyPipe.transform(transliterate(this.form.value.header)),
      language: Language.English
    }

    await this.createPage(this.page);
    if (this.page_eng.header && this.page_eng.menuTitle && this.page_eng.content) {
      console.log(this.page);
      console.log(this.page_eng);
      await this.createPage(this.page_eng);
    }
  }
}
