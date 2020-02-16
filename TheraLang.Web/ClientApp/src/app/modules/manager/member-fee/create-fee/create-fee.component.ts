import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { MemberFee } from 'src/app/shared/models/member-fee/member-fee';
import { MemberFeeService } from 'src/app/core/http/manager/fee.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-create-fee',
  templateUrl: './create-fee.component.html',
  styleUrls: ['./create-fee.component.less']
})
export class CreateFeeComponent implements OnInit {
  memberFee: MemberFee = new MemberFee();
  memberFees: MemberFee[] = [];
  constructor(
    private router: Router,
    private memberFeeService: MemberFeeService) { }

  ngOnInit() {

  }

  save() {
    if (this.memberFee.id == null) {
      this.memberFeeService.createMemberFee(this.memberFee)
        .subscribe((data: MemberFee) => {
          console.log(data)
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
  

}
