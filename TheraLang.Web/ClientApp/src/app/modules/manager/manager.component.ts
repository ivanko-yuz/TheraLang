import { Component, OnInit } from "@angular/core";
import { TranslateService } from "@ngx-translate/core";

@Component({
  selector: "app-manager",
  templateUrl: "./manager.component.html",
  styleUrls: ["./manager.component.less"]
})
export class ManagerComponent implements OnInit {
  constructor(translate: TranslateService) {
    translate.setDefaultLang("ua");

    // the lang to use, if the lang isn't available, it will use the current loader to get them
    translate.use("ua");
  }

  ngOnInit() {}
}
