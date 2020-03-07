import { Component, OnInit, Inject } from '@angular/core';
import { Page } from 'src/app/shared/models/page/page.model';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { DialogService } from 'src/app/core/services/dialog/dialog.service';
import { Language } from 'src/app/shared/models/language/languages.enum';

@Component({
  selector: 'app-page-preview',
  templateUrl: './page-preview.component.html',
  styleUrls: ['./page-preview.component.less']
})
export class PagePreviewComponent implements OnInit {
  page: Page
  constructor(
    public dialogRef: MatDialogRef<PagePreviewComponent>,
    @Inject(MAT_DIALOG_DATA) public pageView) {
      this.page = pageView; 
    }

  ngOnInit() {  }
}
