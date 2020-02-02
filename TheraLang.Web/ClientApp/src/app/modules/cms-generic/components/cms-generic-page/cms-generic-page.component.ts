import { Component, OnDestroy, OnInit } from "@angular/core";
import { CmsRouteHelperService } from "../../../../core/services/cms/cms-route-helper.service";
import { Subscription } from "rxjs";
import { Router } from "@angular/router";
import { CmsRoute } from "src/app/modules/main/toolbar/toolbar-item/cms-route";

@Component({
  selector: "app-cms-generic-page",
  templateUrl: "./cms-generic-page.component.html",
  styleUrls: ["./cms-generic-page.component.less"]
})
export class CmsGenericPageComponent implements OnInit, OnDestroy {
  cmsRoute: CmsRoute;
  subscription = new Subscription();

  constructor(
    private cmsRouteHelperService: CmsRouteHelperService,
    private router: Router
  ) {}

  ngOnInit() {
    this.subscribeOnCmsRouteChange();
    if (!this.cmsRoute) {
      this.cmsRouteHelperService.updateRouteByPath(this.router.url);
    }
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }

  subscribeOnCmsRouteChange(): void {
    const subscription = this.cmsRouteHelperService.currentRouteSubject.subscribe(
      next => {
        this.cmsRoute = next;
      }
    );
    this.subscription.add(subscription);
  }
}
