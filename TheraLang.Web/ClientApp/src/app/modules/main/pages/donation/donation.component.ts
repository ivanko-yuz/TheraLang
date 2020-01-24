import { Component, OnInit } from "@angular/core";
import { LiqpayCheckout } from "../../../../shared/models/liqpay-checkout/liqpay-checkout";
import { DonationService } from "../../../../core/http/donations/donation.service";
import { ActivatedRoute } from "@angular/router";
import { liqpayCheckoutUrl } from "src/app/configs/api-endpoint.constants";

@Component({
  selector: "app-donation",
  templateUrl: "./donation.component.html",
  styleUrls: ["./donation.component.less"]
})
export class DonationComponent implements OnInit {
  donationModel: LiqpayCheckout;
  donationAmount: string;
  projectId: number;

  constructor(
    private donationService: DonationService,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.projectId = +params.get("projectId");
    });
  }

  checkout() {
    if (this.projectId !== 0) {
      this.donationService
        .getProjectCheckoutModel(this.donationAmount, this.projectId)
        .subscribe((checkoutModel: LiqpayCheckout) => {
          this.donationModel = checkoutModel;
          window.location.replace(
            `${liqpayCheckoutUrl}?data=${this.donationModel.data}&signature=${this.donationModel.signature}`
          );
        });
    } else {
      this.donationService
        .getSocietyCheckoutModel(this.donationAmount)
        .subscribe((checkoutModel: LiqpayCheckout) => {
          this.donationModel = checkoutModel;
          window.location.replace(
            `${liqpayCheckoutUrl}?data=${this.donationModel.data}&signature=${this.donationModel.signature}`
          );
        });
    }
  }
}
