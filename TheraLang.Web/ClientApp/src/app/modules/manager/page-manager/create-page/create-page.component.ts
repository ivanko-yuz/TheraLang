import {Component, OnInit} from '@angular/core';
import {FormControl, FormGroup, Validators} from '@angular/forms';
import { PageService } from 'src/app/core/http/page/page.service';
import { Newpage } from 'src/app/shared/models/new_page/newpage';

@Component({
  selector: 'app-create-page',
  templateUrl: './create-page.component.html',
  styleUrls: ['./create-page.component.less']
})
export class CreatePageComponent implements OnInit {

  form: FormGroup;

  constructor(private pageService: PageService) {
  }

  ngOnInit() {
    this.form = new FormGroup({
      title: new FormControl(null, Validators.required),
      text: new FormControl(null, Validators.required),
      author: new FormControl(null, Validators.required)
    })
  }

  submit() {
    const page: Newpage = {
      title: this.form.value.title,
      text: this.form.value.text,
      date: new Date()
    }

    console.log(page)
  }
}
