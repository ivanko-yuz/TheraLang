import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { PaymentHistoryService } from 'src/app/core/http/manager/paymentHistory.services';
import { PaymentHistory } from 'src/app/shared/models/payment-history/payment-history';

@Component({
  selector: 'app-payment-history',
  templateUrl: './payment-history.component.html',
  styleUrls: ['./payment-history.component.less']
})
export class PaymentHistoryComponent implements OnInit {
  
  paymentHistory: PaymentHistory = new PaymentHistory();
  paymentsHistory: PaymentHistory[] = [];
  constructor(
    private router:Router,
    private paymentHistoryService: PaymentHistoryService
  ) { }

  ngOnInit() {
    this.loadPaymentsHistory();
  }

  loadPaymentsHistory() {
    this.paymentHistoryService.getPaymentHistory().subscribe({
      next: (data: PaymentHistory[]) => {
         this.paymentsHistory = data;
      }
    });
  }
}
