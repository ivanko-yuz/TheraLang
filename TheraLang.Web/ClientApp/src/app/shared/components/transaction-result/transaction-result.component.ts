import { Component, OnInit } from "@angular/core";
import { DonationService } from "../../../core/http/donations/donation.service";
import { ActivatedRoute } from "@angular/router";
import { LiqpayResponse } from "../../models/lisqpay-response/liqpay-response";

@Component({
  selector: "app-transaction-result",
  templateUrl: "./transaction-result.component.html",
  styleUrls: ["./transaction-result.component.less"]
})
export class TransactionResultComponent implements OnInit {
  liqpayResponse: LiqpayResponse;
  donationId: string;

  constructor(
    private route: ActivatedRoute,
    private donationService: DonationService
  ) {}

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.donationId = params.get("donationId");
      this.donationService
        .getDonationTransaction(this.donationId)
        .subscribe((liqpayResponseData: LiqpayResponse) => {
          this.liqpayResponse = liqpayResponseData;
        });
    });
  }
}
