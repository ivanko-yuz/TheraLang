import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { paymentHistoryUrl } from "src/app/configs/api-endpoint.constants";

@Injectable()
export class PaymentHistoryService {
    constructor(private http: HttpClient) {
    }

    getPaymentHistory() {
        return this.http.get(paymentHistoryUrl);
    }
}
