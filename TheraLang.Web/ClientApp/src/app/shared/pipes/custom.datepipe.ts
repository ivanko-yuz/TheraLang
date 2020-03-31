import { Pipe, PipeTransform } from "@angular/core";
import { DatePipe } from "@angular/common";
import { LONG_DATE_STRING } from "src/app/configs/date-formats";

@Pipe({
  name: "customDate",
})
export class CustomDatePipe extends DatePipe implements PipeTransform {
  transform(value: any, args?: any): any {
    return super.transform(value, LONG_DATE_STRING);
  }
}
