import { Component, OnInit } from '@angular/core';
import { LiqpayCheckout } from './liqpay-checkout'
import { DonationService } from './donation.service';
import { ActivatedRoute } from '@angular/router';
import { liqpayCheckoutUrl } from '../shared/api-endpoint.constants';
import { SocietyDonation } from './society-donation';

@Component({
  selector: 'app-donation',
  templateUrl: './donation.component.html',
  styleUrls: ['./donation.component.less']
})
export class DonationComponent implements OnInit {

  donationModel: LiqpayCheckout;
  donationAmount: string;
  projectId: number;
  societyDontion: SocietyDonation;

  constructor(private donationService: DonationService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.projectId = +params.get('projectId');
      this.donationService.getSocietyDonationSum().subscribe((societyDontion: SocietyDonation) => this.societyDontion = societyDontion);
    });
  }

  checkout() {
    if(this.projectId !== 0) {
      this.donationService.getProjectCheckoutModel(this.donationAmount, this.projectId).subscribe((checkoutModel: LiqpayCheckout) => {
        this.donationModel = checkoutModel;
        window.location.replace(`${liqpayCheckoutUrl}?data=${this.donationModel.data}&signature=${this.donationModel.signature}`);
      });
    }
    else {
    this.donationService.getSocietyCheckoutModel(this.donationAmount).subscribe((checkoutModel: LiqpayCheckout) => {
      this.donationModel = checkoutModel;
      window.location.replace(`${liqpayCheckoutUrl}?data=${this.donationModel.data}&signature=${this.donationModel.signature}`);
    });
  }

  }
}
