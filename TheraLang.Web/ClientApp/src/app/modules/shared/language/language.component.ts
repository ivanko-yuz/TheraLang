import {Component, OnInit, ViewChild, Input} from '@angular/core';
import {TranslateService} from '@ngx-translate/core';
import {LanguageService} from "../../../core/services/language/language.service";
import {Language} from "../../../shared/models/language/languages.enum";

@Component({
  selector: 'app-language',
  templateUrl: './language.component.html',
  styleUrls: ['./language.component.less']
})
export class LanguageComponent implements OnInit {


  @ViewChild('menu', {static: false}) menu: any;
  languages: Language[];
  currentLang : string;
  country : string;

  constructor(
    private translate: TranslateService,
    public languageService: LanguageService
    ) { }

  ngOnInit() {
    this.languages = this.languageService.languages;
    this.getCurrentLang();
    this.getLangCountry();
  }

  changeLang(lang: Language): void {
    this.languageService.setLanguage(lang);
    this.translate.use(this.languageService.langToString(lang));
  }

  getCurrentLang()
  {
    this.currentLang = Language[this.languageService.getCurrentLang()];
    return this.currentLang;
  }

  getLangCountry() {
    this.country = this.currentLang.toLowerCase();
    if(this.country == "en")
      this.country = "us";

    return this.country;
  }
}
