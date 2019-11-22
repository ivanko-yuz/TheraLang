import { Page } from '../models/root-object.model';
import { Component, OnInit } from '@angular/core';
import { HttpService } from 'src/app/project/http.service';

@Component({
  selector: 'app-piranha-page',
  templateUrl: './piranha-page.component.html',
  styleUrls: ['./piranha-page.component.less']
})
export class PiranhaPageComponent implements OnInit {
  page: Page;
  model: any;
  ifGenerate: boolean = false;
  constructor(private http: HttpService) { }

  async ngOnInit() {
    this.page = await this.http.getAboutPage("b7a401db-61ba-4308-a9c1-c38a291cc497");
    console.log(this.page.slug);
    this.ifGenerate = true;
  }

}
