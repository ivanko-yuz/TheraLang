import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { PageService } from "src/app/core/http/manager/page.service";
import { Page } from "src/app/shared/models/page/page.model";

@Component({
  selector: "app-page",
  templateUrl: "./page.component.html",
  styleUrls: ["./page.component.less"]
})
export class PageComponent implements OnInit {
  page: Page;
  constructor(
    private pageService: PageService,
    private router: ActivatedRoute
  ) {}

  ngOnInit() {
    const pageRoute: string = this.router.snapshot.params["pageRoute"];
    this.pageService.getPageByRoute(pageRoute).subscribe({
      next: data => {
        this.page = data as Page;
        console.log(data);
      }
    });
  }
}
