import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-news-create',
  templateUrl: './news-create.component.html',
  styleUrls: ['./news-create.component.less']
})
export class NewsCreateComponent implements OnInit {

  public newsForm: FormGroup;

  constructor() { 
    this.newsForm = new FormGroup({
      "title":new FormControl("",[Validators.maxLength(250), Validators.minLength(3)]),
      "text":new FormControl("", [Validators.maxLength(10000), Validators.minLength(5)]),
      "previewImage":new FormControl(null),
      "contentImages":new FormControl()
    });
  }

  ngOnInit() {
  }

}
