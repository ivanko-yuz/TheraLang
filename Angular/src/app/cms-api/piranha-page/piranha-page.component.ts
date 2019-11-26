import { Page } from '../models/root-object.model';
import { Component, OnInit, Input } from '@angular/core';
import { HttpService } from 'src/app/project/http.service';
import { CmsRoute } from 'src/app/toolbar/toolbar-item/cms-route';

@Component({
  selector: 'app-piranha-page',
  templateUrl: './piranha-page.component.html',
  styleUrls: ['./piranha-page.component.less']
})
export class PiranhaPageComponent implements OnInit {
  page: Page;
  @Input() cmsRoute: CmsRoute;
  ifGenerate: boolean = false;
  constructor(private http: HttpService) { }

  async ngOnInit() {
    this.page = await this.http.getPiranhaPageById(this.cmsRoute.id);
    this.ifGenerate = true;
  }

}
