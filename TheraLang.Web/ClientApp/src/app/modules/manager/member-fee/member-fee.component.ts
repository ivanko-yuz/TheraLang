import { Component, OnInit } from '@angular/core';
import { MemberFee } from 'src/app/shared/models/member-fee/member-fee';
import { MemberFeeService } from 'src/app/core/http/manager/fee.service';

@Component({
  selector: 'app-member-fee',
  templateUrl: './member-fee.component.html',
  styleUrls: ['./member-fee.component.less']
})
export class MemberFeeComponent implements OnInit {
  
  memberFee: MemberFee = new MemberFee();    // изменяемый товар
  memberFees: MemberFee[];                   // массив товаров
  tableMode: boolean = true;               // табличный режим
  constructor(private memberFeeService: MemberFeeService) { }

  ngOnInit() {
    this.loadMemberFees();
  }

  loadMemberFees() {
    this.memberFeeService.getMemberFees()
        .subscribe((data: MemberFee[]) => this.memberFees = data);
  }
  save() {
    if (this.memberFee.id == null) {
        this.memberFeeService.createMemberFee(this.memberFee)
            .subscribe((data: MemberFee) => this.memberFees.push(data));
    }
    this.cancel();
}

cancel() {
    this.memberFee = new MemberFee();
    this.tableMode = true;
}
delete(fee: MemberFee) {
    this.memberFeeService.deleteMemberFee(fee.id)
        .subscribe(data => this.loadMemberFees());
}
add() {
    this.cancel();
    this.tableMode = false;
    this.loadMemberFees();
}

}
