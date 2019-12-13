import { __decorate } from "tslib";
import { Component } from '@angular/core';
let TransactionResultComponent = class TransactionResultComponent {
    constructor(route, donationService) {
        this.route = route;
        this.donationService = donationService;
    }
    ngOnInit() {
        this.route.paramMap.subscribe(params => {
            this.donationId = params.get('donationId');
            this.donationService.getLiqpayResponse(this.donationId).subscribe((liqpayResponseData) => {
                this.liqpayResponse = liqpayResponseData;
            });
        });
    }
};
TransactionResultComponent = __decorate([
    Component({
        selector: 'app-transaction-result',
        templateUrl: './transaction-result.component.html',
        styleUrls: ['./transaction-result.component.less']
    })
], TransactionResultComponent);
export { TransactionResultComponent };
//# sourceMappingURL=transaction-result.component.js.map