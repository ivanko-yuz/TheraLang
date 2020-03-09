import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { MemberFee } from 'src/app/shared/models/member-fee/member-fee';
import { MemberFeeService } from 'src/app/core/http/manager/fee.service';
import { Router } from '@angular/router';
import {FormControl, FormGroup} from '@angular/forms';
import {MomentDateAdapter, MAT_MOMENT_DATE_ADAPTER_OPTIONS} from '@angular/material-moment-adapter';
import {DateAdapter, MAT_DATE_FORMATS, MAT_DATE_LOCALE} from '@angular/material/core';
import {MatDatepicker} from '@angular/material/datepicker';

import * as _moment from 'moment';

 const moment = _moment;

export const MY_FORMATS = {
  parse: {
    dateInput: 'MM/YYYY',
  },
  display: {
    dateInput: 'MM/YYYY',
    monthYearLabel: 'MMM YYYY',
    dateA11yLabel: 'LL',
    monthYearA11yLabel: 'MMMM YYYY',
  },
};
@Component({
  selector: 'app-create-fee',
  templateUrl: './create-fee.component.html',
  styleUrls: ['./create-fee.component.less'],
  providers: [

    {
      provide: DateAdapter,
      useClass: MomentDateAdapter,
      deps: [MAT_DATE_LOCALE, MAT_MOMENT_DATE_ADAPTER_OPTIONS]
    },

    {provide: MAT_DATE_FORMATS, useValue: MY_FORMATS},
  ]
})
export class CreateFeeComponent implements OnInit {
  memberFee: MemberFee = new MemberFee();
  memberFees: MemberFee[] = [];
  date = new FormControl(moment());
  
  constructor(
    private router: Router,
    private memberFeeService: MemberFeeService
    ) { }

  ngOnInit() {
    this.memberFee.feeDate = this.date.value,
    this.memberFee.feeAmount = 1
  }

  save() {
    if (this.memberFee.id == null) {
      this.memberFeeService.createMemberFee(this.memberFee)
        .subscribe((data: MemberFee) => {
          return this.memberFees.push(data);
        });
    }
    this.cancel();
  }

  cancel() {
    this.memberFee = new MemberFee();
    this.router.navigate(['admin', 'fee']);
  }

  add() {
    this.cancel();
  }

  chosenYearHandler(normalizedYear: _moment.Moment) {
    const ctrlValue = this.date.value;
    ctrlValue.year(normalizedYear.year());
    this.date.setValue(ctrlValue);
    this.memberFee.feeDate = this.date.value;
  }

  chosenMonthHandler(normalizedMonth: _moment.Moment, datepicker: MatDatepicker<_moment.Moment>) {
    const ctrlValue = this.date.value;
    ctrlValue.month(normalizedMonth.month());
    this.date.setValue(ctrlValue);
    this.memberFee.feeDate = this.date.value;
    datepicker.close();
  }  
}
