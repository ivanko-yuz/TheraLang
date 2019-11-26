import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DonationService } from '../donation/donation.service';
import { LiqpayResponse } from './liqpay-response';

@Component({
  selector: 'app-result',
  templateUrl: './result.component.html',
  styleUrls: ['./result.component.less']
})
export class ResultComponent implements OnInit {

  liqpayResponse: LiqpayResponse;
  donationId: string;

  constructor(private route: ActivatedRoute, private donationService: DonationService) { }

  ngOnInit() {

    this.route.paramMap.subscribe(params => {
      this.donationId = params.get('donationId');
      this.donationService.getLiqpayResponse(this.donationId).subscribe((liqpayResponseData: LiqpayResponse) => {
        this.liqpayResponse = liqpayResponseData;
      });
    });

  }

}


