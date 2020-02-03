import { Component, OnInit, ElementRef } from '@angular/core';
import { FormControl, FormGroup, Validators, NG_VALUE_ACCESSOR } from '@angular/forms';
import { PageService } from 'src/app/modules/manager/shared/services/page.service';
import { Newpage } from 'src/app/shared/models/new_page/newpage';
import { Location } from '@angular/common';
import Quill from 'quill';

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
      title: new FormControl(null, [Validators.required, Validators.maxLength(60)]),
      text: new FormControl(null, [Validators.required, Validators.maxLength(5000)])
    })
  }

  public onCancel = () => {
    this.location.back();
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.form.controls[controlName].hasError(errorName);
  }

  submit() {
    const page: Newpage = {
      title: this.form.value.title,
      text: this.form.value.text
    }

    console.log(page)
    this.pageService.addPage(page);
  }
}
