import {Injectable} from '@angular/core';
import {Language} from "../../../shared/models/language/languages.enum";

@Injectable({
  providedIn: 'root'
})
export class LanguageService {
  private defaultLang: Language = Language.ua;

  public languages: Language[];

  constructor() {
    this.languages = Object.keys(Language)
      .filter((elem) => !Number.isInteger(parseInt(elem)))
      .map(val => Language[val]);
  }

  langToString(lang: Language): string {
    return Language[lang];
  }

  getCurrentLang(): Language{
    return Language[localStorage.getItem("lang")] || this.defaultLang;
  }

  setLanguage(lang: Language): void{
    return localStorage.setItem("lang",Language[lang]);
  }
}
