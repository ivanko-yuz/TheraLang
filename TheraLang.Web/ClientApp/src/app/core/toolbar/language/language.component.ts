import {Component, OnInit, ViewChild, Input} from '@angular/core';
import {TranslateService} from '@ngx-translate/core';

@Component({
  selector: 'app-language',
  templateUrl: './language.component.html',
  styleUrls: ['./language.component.less']
})
export class LanguageComponent implements OnInit {


  @ViewChild('menu', {static: false}) menu: any;
  languages = ['en', 'ua'];

  constructor(private translate: TranslateService) { }

  ngOnInit() {
  }

  changeLang(lang: string): void {
    this.translate.use(lang);
  }

}
