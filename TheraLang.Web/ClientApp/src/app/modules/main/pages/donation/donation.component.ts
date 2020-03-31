import { Component, OnInit } from "@angular/core";
import { LiqpayCheckout } from "../../../../shared/models/liqpay-checkout/liqpay-checkout";
import { DonationService } from "../../../../core/http/donations/donation.service";
import { ActivatedRoute } from "@angular/router";
import { liqpayCheckoutUrl } from "src/app/configs/api-endpoint.constants";
import {AbstractControl, FormBuilder, FormControl, FormGroup, Validators} from "@angular/forms";

@Component({
  selector: "app-donation",
  templateUrl: "./donation.component.html",
  styleUrls: ["./donation.component.less"],
})
export class DonationComponent implements OnInit {
  donationModel: LiqpayCheckout;
  projectId: number;
  amountForm: FormGroup;

  maxDonationValue = 9999999999;
  minDonationValue = 0;

  constructor(
    private donationService: DonationService,
    private route: ActivatedRoute,
    private formBuilder: FormBuilder,
  ) {}

  ngOnInit() {
    this.amountForm = this.formBuilder.group({
      donationAmount: [null, [Validators.required, Validators.min(this.minDonationValue), Validators.max(this.maxDonationValue)]],
    });
    this.route.paramMap.subscribe(params => {
      this.projectId = +params.get("projectId");
    });
  }

  checkout() {
    if (this.projectId !== 0) {
      this.donationService
        .getProjectCheckoutModel(this.amountForm.value.donationAmount, this.projectId)
        .subscribe((checkoutModel: LiqpayCheckout) => {
          this.donationModel = checkoutModel;
          window.location.replace(
            `${liqpayCheckoutUrl}?data=${this.donationModel.data}&signature=${this.donationModel.signature}`,
          );
        });
    } else {
      const societyId = 1;
      this.donationService
        .getSocietyCheckoutModel(this.amountForm.value.donationAmount, societyId)
        .subscribe((checkoutModel: LiqpayCheckout) => {
          this.donationModel = checkoutModel;
          window.location.replace(
            `${liqpayCheckoutUrl}?data=${this.donationModel.data}&signature=${this.donationModel.signature}`,
          );
        });
    }
  }

  clear() {
    this.amountForm.setValue({
      donationAmount: null,
    });
  }

  limit(event: KeyboardEvent) {
    console.log(event);
    const key = event.key;
    if (!parseInt(key)) {

    }
  }
}
