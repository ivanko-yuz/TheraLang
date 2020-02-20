import { Component, Inject, OnInit } from "@angular/core";
import { MAT_DIALOG_DATA, MatDialogRef } from "@angular/material";
import { DialogData } from "../../main/pages/project/project-info/resources-table-for-project/project-type/project-type.component";

@Component({
  selector: "app-change-role",
  templateUrl: "./change-role.component.html",
})
export class ChangeRoleComponent {
  selectedValue: string;

  constructor(
    public dialogRef: MatDialogRef<ChangeRoleComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any) {
    console.log(data);
  }

  onNoClick(): void {
    this.dialogRef.close();
  }
}
