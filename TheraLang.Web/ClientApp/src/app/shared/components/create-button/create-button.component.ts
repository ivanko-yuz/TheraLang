import {Component, EventEmitter, Input, OnInit, Output} from "@angular/core";

@Component({
  selector: "app-create-button",
  templateUrl: "./create-button.component.html",
  styleUrls: ["./create-button.component.less"],
})
export class CreateButtonComponent implements OnInit {

  @Output() clicked: EventEmitter<any> = new EventEmitter<any>();

  constructor() { }

  ngOnInit() {
  }

}
