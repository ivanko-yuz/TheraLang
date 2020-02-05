import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators, NG_VALUE_ACCESSOR } from '@angular/forms';
import { PageService } from 'src/app/modules/manager/shared/services/page.service';
import { Newpage } from 'src/app/shared/models/new_page/newpage';
import { Location } from '@angular/common';

@Component({
  selector: 'app-create-page',
  templateUrl: './create-page.component.html',
  styleUrls: ['./create-page.component.less']
})
export class CreatePageComponent implements OnInit {

  form: FormGroup;

  constructor(private pageService: PageService, private location: Location) {
  }

  ngOnInit() {
    this.form = new FormGroup({
      header: new FormControl(null, [Validators.required, Validators.maxLength(60)]),
      content: new FormControl(null, [Validators.required, Validators.maxLength(5000)]),
      menuName: new FormControl(null, [Validators.required, Validators.maxLength(60)])
    })
  }

  public onCancel = () => {
    this.location.back();
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.form.controls[controlName].hasError(errorName);
  }

  submit() {
    if (this.form.invalid) {
      return;
    }

    const page: Newpage = {
      header: this.form.value.header,
      content: this.form.value.content,
      menuName: this.form.value.menuName
    }

    this.pageService.addPage(page);
  }
}
