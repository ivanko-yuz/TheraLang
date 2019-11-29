import { __decorate } from "tslib";
import { Pipe } from '@angular/core';
import { DatePipe } from '@angular/common';
import * as Constants from '../shared/constants/date-formats';
let CustomDatePipe = class CustomDatePipe extends DatePipe {
    transform(value, args) {
        return super.transform(value, Constants.DateFormatsConstants.LONG_DATE_STRING);
    }
};
CustomDatePipe = __decorate([
    Pipe({
        name: 'customDate'
    })
], CustomDatePipe);
export { CustomDatePipe };
//# sourceMappingURL=custom.datepipe.js.map