import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
import { donationUrl } from '../shared/api-endpoint.constants';
let DonationService = class DonationService {
    constructor(http) {
        this.http = http;
    }
    getCheckoutModel(donationAmount, projectId) {
        return this.http.get(`${donationUrl}/${donationAmount}/${projectId}`);
    }
    getLiqpayResponse(donationId) {
        return this.http.get(`${donationUrl}/${donationId}`);
    }
};
DonationService = __decorate([
    Injectable()
], DonationService);
export { DonationService };
//# sourceMappingURL=donation.service.js.map