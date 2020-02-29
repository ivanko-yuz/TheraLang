import {Component, Input, OnInit} from '@angular/core';
import {ResourceCategory} from 'src/app/shared/models/resource/resource-category';
import {ResourceService} from "../../../../../../core/http/resource/resource.service";
import {Observable, throwError} from "rxjs";
import {Resource} from "../../../../../../shared/models/resource/resource";
import {catchError, map, share} from "rxjs/operators";
import {PaginationInstance} from "ngx-pagination";
import {DialogService} from "../../../../../../core/services/dialog/dialog.service";
import {TranslateService} from "@ngx-translate/core";

@Component({
  selector: 'app-resource-category',
  templateUrl: './resource-category.component.html',
  styleUrls: ['./resource-category.component.less']
})
export class ResourceCategoryComponent implements OnInit {

  @Input() category: ResourceCategory;
  @Input() projectId: number;
  pageSize: number = 6;
  maxPagesOnControls:number = 5;

  paginationConfig: PaginationInstance = {
    currentPage: 1,
    itemsPerPage: this.pageSize
  };
  loaded: boolean = false;

  resources: Observable<Resource[]>;

  constructor(
    private resourceService: ResourceService,
    private dialogService: DialogService,
    private translate: TranslateService
  ) { }

  ngOnInit() {
    this.paginationConfig.id = this.category.type;
    this.resourceService.countTotalResources(this.category.id,this.projectId).toPromise()
      .then(res => {
        this.paginationConfig.totalItems = res as number;
        this.onPageChange(1);
        this.loaded = true;
      });
  }

  onPageChange(pageNumber:number){
    this.resources = this.getPage(pageNumber);
  }

  getPage(pageNumber: number) : Observable<Resource[]>{
    return this.resourceService.getRosourcesByCategory(this.category.id, this.projectId, pageNumber, this.pageSize).pipe(
      catchError(err => {
        return throwError(err);
      }),
      map(res => {
        this.paginationConfig.currentPage = pageNumber;
        return res;
      })
    )
  }

  onDelete(resourceId: number) {
    this.translate.get("common.r-u-sure").subscribe({
      next: value => {
        this.dialogService
          .openConfirmDialog(value)
          .afterClosed()
          .subscribe({
            next: res => {
              this.resourceService.deleteResource(resourceId).subscribe(
                res => {
                  this.onPageChange(this.paginationConfig.currentPage);
                  this.resourceService.countTotalResources(this.category.id,this.projectId).subscribe({
                    next: value1 => this.paginationConfig.totalItems = value1 as number
                  })
                });
            }
          });
      }
    })
  }
}
