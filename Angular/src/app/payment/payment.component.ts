import { Component, OnInit } from '@angular/core';
import { HttpService } from '../project/http.service';
import { LiqPayCheckoutFormModel } from './liq-pay-checkout-form-model';
import {FormControl, Validators} from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
  styleUrls: ['./payment.component.less']
})
export class PaymentComponent implements OnInit {

  payment: LiqPayCheckoutFormModel;
  donationAmount: string;
  projectId: number = 1;
  private url = "https://localhost:44353/api/";

  constructor(private httpService: HttpService, private http1: HttpClient) { }

  ngOnInit() {
    // this.httpService.getPayment().subscribe((payment: LiqPayCheckoutFormModel)=> this.payment = payment);
  }
 
  submit(){

    console.log(this.donationAmount);
    this.http1.get(`${this.url}payment/${this.donationAmount}/${this.projectId}`).subscribe((requestData: LiqPayCheckoutFormModel) => {
      this.payment = requestData;
      window.open(`https://www.liqpay.ua/api/3/checkout?data=${this.payment.data}&signature=${this.payment.signature}`, "_blank") ;
    });  
    
  }

  // this.http1.post(this.url + 'payment', this.donationAmount).subscribe((requestData: LiqPayCheckoutFormModel) => {
  //   this.payment = requestData;
  //   console.log(this.donationAmount);
  //   window.open(`https://www.liqpay.ua/api/3/checkout?data=${this.payment.data}&signature=${this.payment.signature}`, "_blank") ;
  
}
