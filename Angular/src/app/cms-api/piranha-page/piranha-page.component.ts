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
    // There will be used service from uttmm-46.
    this.page = await this.http.getPiranhaPageById(); 
    this.ifGenerate = true;
  }

}
