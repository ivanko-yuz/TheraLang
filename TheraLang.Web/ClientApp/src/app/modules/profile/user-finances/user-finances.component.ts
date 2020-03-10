import { Component, OnInit, Input } from '@angular/core';
import { User } from 'src/app/shared/models/user/user';
import { DonationService } from 'src/app/core/http/donations/donation.service';
import { LiqpayCheckout } from 'src/app/shared/models/liqpay-checkout/liqpay-checkout';
import { liqpayCheckoutUrl } from 'src/app/configs/api-endpoint.constants';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-user-finances',
  templateUrl: './user-finances.component.html',
  styleUrls: ['./user-finances.component.less']
})
export class UserFinancesComponent implements OnInit {
  @Input() user: User;
  donationModel: LiqpayCheckout;
  amountForm: FormGroup;

  maxDonationValue: number = 9999999999;
  minDonationValue: number = 0;

  constructor(
    private donationService: DonationService,
    private formBuilder: FormBuilder
  ) { }

  ngOnInit() {
    this.amountForm = this.formBuilder.group({
      donationAmount: [null, [Validators.required, Validators.min(this.minDonationValue), Validators.max(this.maxDonationValue)]]
    });
  }

  onTopUp(){  
     this.donationService
    .getTopUpCheckoutModel(this.amountForm.value["donationAmount"], this.user.id)
    .subscribe((checkoutModel: LiqpayCheckout) => {
      this.donationModel = checkoutModel;
      window.location.replace(
        `${liqpayCheckoutUrl}?data=${this.donationModel.data}&signature=${this.donationModel.signature}`
      );
    });  
  }

}
