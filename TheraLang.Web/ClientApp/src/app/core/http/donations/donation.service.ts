import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { donationUrl } from "src/app/configs/api-endpoint.constants";

@Injectable()
export class DonationService {
  constructor(private http: HttpClient) {}

  getProjectCheckoutModel(donationAmount: string, projectId: number) {
    return this.http.get(`${donationUrl}/liqpay/?donationAmount=${donationAmount}&projectId=${projectId}&action=paydonate&currency=uah&language=uk&description=blagodiynist`);
  }

  getSocietyCheckoutModel(donationAmount: string) {
    return this.http.get(`${donationUrl}/liqpay/?donationAmount=${donationAmount}&societyId=1&action=paydonate&currency=uah&language=uk&description=blagodiynist`);
  }

  getDonationTransaction(donationId: string) {
    return this.http.get(`${donationUrl}/${donationId}`);
  }
}
