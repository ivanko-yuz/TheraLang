import { Injectable } from "@angular/core";
import { MatDialog, MatDialogConfig } from "@angular/material";
import { ConfirmDialogComponent } from "../../../shared/components/confirm-dialog/confirm-dialog.component";
import { Page } from 'src/app/shared/models/page/page.model';
import { PagePreviewComponent } from 'src/app/modules/manager/page-manager/page-preview/page-preview.component';

@Injectable({
  providedIn: "root"
})
export class DialogService {
  constructor(private dialog: MatDialog) {}

  openConfirmDialog(msg) {
    return this.dialog.open(ConfirmDialogComponent, {
      width: "390px",
      panelClass: "confirm-dialog-container",
      disableClose: true,
      position: { top: "10px" },
      data: {
        message: msg
      }
    });
  }
  openFormDialog(formComponent) {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;
    dialogConfig.width = "60%";
    dialogConfig.panelClass = "form";
    this.dialog.open(formComponent, dialogConfig);
  }

  openPagePreviewDialog(page: Page){
    const dialogRef = this.dialog.open(PagePreviewComponent, {
      width: "60%",
      height: "98%",
      data: page
    });
  }

  closeDialogs() {
    this.dialog.closeAll();
  }
}
