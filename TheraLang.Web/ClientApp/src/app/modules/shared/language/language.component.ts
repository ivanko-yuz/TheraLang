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

  constructor(
    private translate: TranslateService,
    public languageService: LanguageService
    ) { }

  ngOnInit() {
    this.languages = this.languageService.languages;
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
    if(!this.currentLang){
      this.getCurrentLang();
    }

    let country = this.currentLang.toLowerCase();
    if(country == "en")
      country = "us";

    return country;
  }
}
