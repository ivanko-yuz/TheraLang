import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common'
@Component({
  selector: 'app-error',
  templateUrl: './error.component.html',
  styleUrls: ['./error.component.less']
})
export class ErrorComponent implements OnInit {

  constructor(private location: Location) { }

  ngOnInit() {
  }
  
  goBack() {
    this.location.back();
  }
}
