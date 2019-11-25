import { Pipe, PipeTransform } from '@angular/core';
import { DatePipe } from '@angular/common';
import * as Constants  from '../shared/constants/date-formats';

@Pipe({
    name: 'customDate'
  })
  export class CustomDatePipe extends
               DatePipe implements PipeTransform {
    transform(value: any, args?: any): any {
      return super.transform(value, Constants.DateFormatsConstants.LONG_DATE_STRING);
    }
  }
