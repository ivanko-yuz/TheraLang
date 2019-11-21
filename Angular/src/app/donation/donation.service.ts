import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { donationtUrl } from '../shared/api-endpoint.constants';


@Injectable()
export class DonationService {

    constructor(private http: HttpClient) { }

    getCheckoutModel(donationAmount: string, projectId: number) {
        return this.http.get(`${donationtUrl}/${donationAmount}/${projectId}`);
    }

    getLiqpayResponse(donationId: string) {
        return this.http.get(`${donationtUrl}/${donationId}`);

    }

}