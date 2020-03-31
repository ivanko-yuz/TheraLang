import {Component, Input, OnInit} from "@angular/core";
import {Observable, of, throwError} from "rxjs";
import { ResourceCategory } from "src/app/shared/models/resource/resource-category";
import { ResourceService } from "src/app/core/http/resource/resource.service";
import {ActivatedRoute, Router} from "@angular/router";
import {catchError, map} from "rxjs/operators";

@Component({
  selector: "app-resources-view",
  templateUrl: "./resources-view.component.html",
  styleUrls: ["./resources-view.component.less"],
})
export class ResourcesViewComponent implements OnInit {

  @Input() projectId: number;

  loadedCategories: Set<number> = new Set<number>();
  categories: Observable<ResourceCategory[]>;
  selectedIndex: number;

  constructor(
    private resourceService: ResourceService,
    private router: Router,
    private route: ActivatedRoute,
  ) { }

  ngOnInit() {
    const selectedCategoryId: number = parseInt(this.route.snapshot.params.categoryId);
    let index;
    this.categories = this.resourceService.getResourceCategories(this.projectId).pipe(
      catchError(err => {
        return throwError(err);
      }),
      map(response => {

        if (Number.isInteger(selectedCategoryId)) {
          const categories = response as ResourceCategory[];
          index = categories.findIndex(cat => cat.id == selectedCategoryId);
          if (index > 0 && index != this.selectedIndex) {
            setTimeout(() => this.onSelect(index), 100);
          }
          return categories;
        }
        return response;
      }),
    );
  }

  onSelect(pageIndex: number) {
    this.selectedIndex = pageIndex;
    this.loadedCategories.add(pageIndex);
  }
}
