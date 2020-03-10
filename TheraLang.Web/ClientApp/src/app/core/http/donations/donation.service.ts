import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { donationUrl, paymentUrl } from "src/app/configs/api-endpoint.constants";

@Injectable()
export class DonationService {
  constructor(private http: HttpClient) {}

  getProjectCheckoutModel(donationAmount: number, projectId: number) {
    return this.http.get(`${donationUrl}/liqpay/?donationAmount=${donationAmount}&projectId=${projectId}&action=paydonate&currency=uah&language=uk`);
  }

  getSocietyCheckoutModel(donationAmount: number, societyId: number) {
    return this.http.get(`${donationUrl}/liqpay/?donationAmount=${donationAmount}&societyId=${societyId}&action=paydonate&currency=uah&language=uk`);
  }

  getTopUpCheckoutModel(donationAmount: number, memebrId: string) {
    return this.http.get(`${paymentUrl}/liqpay/?donationAmount=${donationAmount}&memberId=${memebrId}&action=paydonate&currency=uah&language=uk`);
  }

  getDonationTransaction(donationId: string) {
    return this.http.get(`${donationUrl}/${donationId}`);
  }
}
