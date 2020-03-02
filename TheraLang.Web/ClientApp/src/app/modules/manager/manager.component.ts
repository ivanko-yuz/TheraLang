import { Component, OnInit } from "@angular/core";
import { TranslateService } from "@ngx-translate/core";
import {LanguageService} from "../../core/services/language/language.service";
import {Language} from "../../shared/models/language/languages.enum";

@Component({
  selector: "app-manager",
  templateUrl: "./manager.component.html",
  styleUrls: ["./manager.component.less"]
})
export class ManagerComponent implements OnInit {
  constructor(
    private translate: TranslateService,
    private languageService: LanguageService
  ) {
    const lang = languageService.getCurrentLang();
    translate.use(Language[lang]);
  }

  ngOnInit() {}
}
