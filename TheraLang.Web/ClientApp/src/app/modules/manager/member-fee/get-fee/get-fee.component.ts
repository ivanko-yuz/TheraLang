import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { MemberFee } from 'src/app/shared/models/member-fee/member-fee';
import { MemberFeeService } from 'src/app/core/http/manager/fee.service';
import { Router } from '@angular/router';
import { DialogService } from 'src/app/core/services/dialog/dialog.service';
import { TranslateService } from '@ngx-translate/core';
import { NotificationService } from 'src/app/core/services/notification/notification.service';

@Component({
  selector: 'app-get-fee',
  templateUrl: './get-fee.component.html',
  styleUrls: ['./get-fee.component.less']
})
export class GetFeeComponent implements OnInit {

  memberFee: MemberFee = new MemberFee();
  memberFees: MemberFee[] = [];
  constructor(
    private router: Router,
    private memberFeeService: MemberFeeService,
    private dialogService: DialogService,
    private translate: TranslateService,
    private notificationService: NotificationService,
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
  async onDelete(fee: MemberFee) {
    this.dialogService
      .openConfirmDialog(await this.translate.get("common.r-u-sure").toPromise())
      .afterClosed()
      .subscribe(async res => {
        if (res) {
            this.memberFeeService.deleteMemberFee(fee.id).subscribe(async result => {
              this.loadMemberFees();
            this.notificationService.success(await this.translate.get("common.deleted-successfully").toPromise());
          });
        }
      },
        async error => {
          console.log(error);
          error = await this.translate
            .get("common.wth")
            .toPromise();
          this.notificationService.warn(error);
        }
      );
  }
}
