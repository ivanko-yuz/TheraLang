import { Component, OnInit } from '@angular/core';
import { LiqpayCheckout } from './liqpay-checkout'
import { DonationService } from './donation.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-donation',
  templateUrl: './donation.component.html',
  styleUrls: ['./donation.component.less']
})
export class DonationComponent implements OnInit {

  donationModel: LiqpayCheckout;
  donationAmount: string;
  projectId: number;

  constructor(private donationService: DonationService, private route: ActivatedRoute) { }

  ngOnInit() {
    debugger
    this.route.paramMap.subscribe(params=>{
      this.projectId = +params.get('projectId');
    });
  }
 
  checkout(){
    this.donationService.getCheckoutModel(this.donationAmount, this.projectId).subscribe((checkoutModel: LiqpayCheckout) => {
      this.donationModel = checkoutModel;
      window.open(`https://www.liqpay.ua/api/3/checkout?data=${this.donationModel.data}&signature=${this.donationModel.signature}`, "_blank") ;
    });  
    
  }
}
