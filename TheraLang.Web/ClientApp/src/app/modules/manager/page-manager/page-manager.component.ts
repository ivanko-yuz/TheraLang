import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-page-manager',
  templateUrl: './page-manager.component.html',
  styleUrls: ['./page-manager.component.less']
})
export class PageManagerComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
  }

}
