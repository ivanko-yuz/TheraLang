import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { MemberFee } from 'src/app/shared/models/member-fee/member-fee';
import { MemberFeeService } from 'src/app/core/http/manager/fee.service';
import { Router} from '@angular/router';

@Component({
  selector: 'app-get-fee',
  templateUrl: './get-fee.component.html',
  styleUrls: ['./get-fee.component.less']
})
export class GetFeeComponent implements OnInit {

  memberFee: MemberFee = new MemberFee();
  memberFees: MemberFee[] = [];
  constructor(
    private router:Router,
    private memberFeeService: MemberFeeService
    ) { }

  ngOnInit() {
    this.loadMemberFees();
  }

  loadMemberFees() {
    this.memberFeeService.getMemberFees().subscribe({
      next: (data: MemberFee[]) => {
         this.memberFees = data;
      }
    });
  }
  delete(fee: MemberFee) {
    this.memberFeeService.deleteMemberFee(fee.id)
      .subscribe(data => this.loadMemberFees());
  }
}
