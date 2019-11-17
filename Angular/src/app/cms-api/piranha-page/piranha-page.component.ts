import { Block } from './../when-get-page-by-slug/block.model';
import { RootObject } from '../when-get-page-by-slug/root-object.mode';
import { CmsService } from '../cms-shared/cms.service';
import { Component, OnInit } from '@angular/core';
import { NgModel } from '@angular/forms';

@Component({
  selector: 'app-piranha-page',
  templateUrl: './piranha-page.component.html',
  styleUrls: ['./piranha-page.component.less']
})
export class PiranhaPageComponent implements OnInit {
  page: RootObject;
  model: any;
  ifGenerate: boolean = false;
  constructor(private http: CmsService) { }

  async ngOnInit() {
    this.page = await this.http.getAboutPage();
    this.page.blocks;
    console.log(this.page.slug);
    this.ifGenerate = true;
    this.page.blocks.forEach(element => {
      element.$type
    });
  }

}
