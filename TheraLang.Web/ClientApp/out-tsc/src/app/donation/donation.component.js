import { __decorate } from "tslib";
import { Component } from '@angular/core';
import { liqpayCheckoutUrl } from '../shared/api-endpoint.constants';
let DonationComponent = class DonationComponent {
    constructor(donationService, route) {
        this.donationService = donationService;
        this.route = route;
    }
    ngOnInit() {
        this.route.paramMap.subscribe(params => {
            this.projectId = +params.get('projectId');
        });
    }
    checkout() {
        this.donationService.getCheckoutModel(this.donationAmount, this.projectId).subscribe((checkoutModel) => {
            this.donationModel = checkoutModel;
            window.open(`${liqpayCheckoutUrl}?data=${this.donationModel.data}&signature=${this.donationModel.signature}`);
        });
    }
};
DonationComponent = __decorate([
    Component({
        selector: 'app-donation',
        templateUrl: './donation.component.html',
        styleUrls: ['./donation.component.less']
    })
], DonationComponent);
export { DonationComponent };
//# sourceMappingURL=donation.component.js.map