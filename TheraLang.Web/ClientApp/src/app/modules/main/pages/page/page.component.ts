import { Component, OnInit } from "@angular/core";
import {ActivatedRoute, ParamMap} from "@angular/router";
import { PageService } from "src/app/core/http/manager/page.service";
import { Page } from "src/app/shared/models/page/page.model";
import {Observable} from "rxjs";
import {switchMap} from "rxjs/operators";

@Component({
  selector: "app-page",
  templateUrl: "./page.component.html",
  styleUrls: ["./page.component.less"],
})
export class PageComponent implements OnInit {
  page: Observable<Page>;
  constructor(
    private pageService: PageService,
    private router: ActivatedRoute,
  ) {}

  ngOnInit() {
    this.router.params.subscribe(params => {
        this.page = this.pageService.getPageByRoute(params.pageRoute) as Observable<Page>;
      },
    );
  }
}
