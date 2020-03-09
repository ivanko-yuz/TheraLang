import {Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges} from '@angular/core';
import { TranslateService } from "@ngx-translate/core";
import { Router, ActivatedRoute } from "@angular/router";
import {MatDialog} from "@angular/material";

@Component({
  selector: "app-pagination",
  templateUrl: "./pagination.component.html",
  styleUrls: ["./pagination.component.less"]
})

export class PaginationComponent implements OnInit, OnChanges {
  @Input() collection: any[];
  @Input() pageSize: number;
  @Input() currentPage = 1;
  @Input() totalRows: number;
  math = Math;
  public totalPages: number;

  @Output() pageChange = new EventEmitter<any>(true);
  public numbers: number[];

  setPage(pageNumber: number) {
    this.currentPage = pageNumber;
    this.pageChange.emit(this.currentPage);
  }

  ngOnChanges(changes: SimpleChanges): void {
  }

  ngOnInit(): void {
    if (this.collection && this.collection.length) {
      this.setPage(this.currentPage);
    }

    this.totalPages = this.math.round(this.totalRows / this.pageSize) - 1;
    // @ts-ignore
    this.numbers = Array(this.totalPages).fill().map((x, i) => i + 1);
  }
}
