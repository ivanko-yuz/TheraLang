import { Component } from "@angular/core";
import { TranslateService } from "@ngx-translate/core";
import {LanguageService} from "./core/services/language/language.service";
import {Language} from "./shared/models/language/languages.enum";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.less"]
})
export class AppComponent {
  title = "UTTMM";
  constructor(
    private translate: TranslateService,
    private languageService: LanguageService
  ) {
  }

  ngOnInit(): void {
    const lang: string = this.languageService.setIfNotExists();
    this.translate.setDefaultLang(lang);
    this.translate.use(lang);
  }
}
