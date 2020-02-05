import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators, NG_VALUE_ACCESSOR } from '@angular/forms';
import { PageService } from 'src/app/modules/manager/shared/services/page.service';
import { Newpage } from 'src/app/shared/models/new_page/newpage';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-page',
  templateUrl: './create-page.component.html',
  styleUrls: ['./create-page.component.less']
})
export class CreatePageComponent implements OnInit {

  form: FormGroup;
  page: Newpage;

  constructor(private pageService: PageService, private router: Router) {
  }

  ngOnInit() {
    this.form = new FormGroup({
      header: new FormControl(null, [Validators.required, Validators.maxLength(60)]),
      content: new FormControl(null, Validators.required),
      menuName: new FormControl(null, [Validators.required, Validators.maxLength(60)])
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
    
    this.pageService.addPage(this.page);
  }
}
