import { Component, OnInit, Output, EventEmitter } from "@angular/core";
import { AuthService } from "src/app/core/auth/auth.service";

@Component({
  selector: "app-project-filters",
  templateUrl: "./project-filters.component.html",
  styleUrls: ["./project-filters.component.less"],
})

export class ProjectFiltersComponent implements OnInit {

  @Output() filtered = new EventEmitter<string>();
  filterQuery = "?";
  search = "";
  sort = "";
  myProjects = false;
  FiltersIsShown = false;
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
    for (const key of this.params.keys()) {
      this.filterQuery += key + "=" + this.params.get(key) + "&";
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
