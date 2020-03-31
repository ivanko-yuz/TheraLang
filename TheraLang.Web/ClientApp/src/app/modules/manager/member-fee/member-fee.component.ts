import { Component, OnInit } from "@angular/core";
import { MemberFee } from "src/app/shared/models/member-fee/member-fee";
import { MemberFeeService } from "src/app/core/http/manager/fee.service";
import { Router } from "@angular/router";

@Component({
  selector: "app-member-fee",
  templateUrl: "./member-fee.component.html",
  styleUrls: ["./member-fee.component.less"],
})
export class MemberFeeComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
  }
}
