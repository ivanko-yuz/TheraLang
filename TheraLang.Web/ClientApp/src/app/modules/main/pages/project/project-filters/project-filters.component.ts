import { Component, OnInit, Output, EventEmitter, Input } from '@angular/core';
import { KeyValue } from '@angular/common';
import { filter, debounceTime } from 'rxjs/operators';
import { keyValuesToMap } from '@angular/flex-layout/extended/typings/style/style-transforms';
import { AuthService } from 'src/app/core/auth/auth.service';

@Component({
  selector: 'app-project-filters',
  templateUrl: './project-filters.component.html',
  styleUrls: ['./project-filters.component.less']
})



export class ProjectFiltersComponent implements OnInit {

  @Input() fieldvalue = '';
  @Output() filtered = new EventEmitter<string>();
  filterQuery: string = "?";
  search: string = "";
  sort: string = "";
  myProjects: boolean = false;
  FiltersIsShown: boolean = false;
  params = new Map<string, string>();
  constructor(private userService: AuthService) { }
  Search() {
    if (this.search != "") {
      this.params.set("search", this.search);
    }
  }

  MyProjects() {
    if (this.myProjects) {
      this.params.set("myprojects", this.myProjects.toString());
    }
  }
  Sort() {
    switch (this.sort) {

      case "sortByDateAsc":
        this.params.set("sortByDateAsc", "true");
        break;
      case "sortByDateDesc":
        this.params.set("sortByDateDesc", "true");
        break;
      case "sortByDaysLeft":
        this.params.set("sortByDaysLeft", "true");
        break;
    }
  }
  onClick() {
    this.Search();
    this.Sort();
    this.MyProjects();
    for (let key of this.params.keys()) {
      this.filterQuery += key + "=" + this.params.get(key) + "&"
    }
    this.filtered.emit(this.filterQuery);
    this.filterQuery = "?";
    this.params.clear();
  }
  ShowFilter() {
    this.FiltersIsShown = !this.FiltersIsShown;
  }
  ngOnInit() {
  }
  isAuthenticated() {
    return this.userService.isAuthenticated();
  }
}

