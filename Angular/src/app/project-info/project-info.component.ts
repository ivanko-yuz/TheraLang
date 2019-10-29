import { Component, OnInit, ViewEncapsulation, ViewChild, AfterViewInit} from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpService } from '../project/http.service';
import { Project } from '../project/project';

import {HttpClient} from '@angular/common/http';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {merge, Observable, of as observableOf} from 'rxjs';
import {catchError, map, startWith, switchMap} from 'rxjs/operators';

@Component({
  selector: 'app-project-info',
  templateUrl: './project-info.component.html',
  styleUrls: ['./project-info.component.less'],
  encapsulation: ViewEncapsulation.None,
  providers:[HttpService]
})
export class ProjectInfoComponent implements OnInit {

  constructor(private route: ActivatedRoute,private http:HttpService) { }

  projectInfo : Project; 

  ngOnInit() {
    this.route.paramMap.subscribe(params=>{
      let id = +params.get('id');
      this.http.getProjectInfo(id).subscribe((data:Project) => this.projectInfo=data);
    });
  }

}

export class TableHttpExample implements AfterViewInit {
  displayedColumns: string[] = ['created', 'state', 'number', 'title'];
  exampleDatabase: ExampleHttpDatabase | null;
  data: GithubIssue[] = [];

  resultsLength = 0;
  isLoadingResults = true;
  isRateLimitReached = false;

  @ViewChild(MatPaginator, {static: false}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: false}) sort: MatSort;

  constructor(private _httpClient: HttpClient) {}

  ngAfterViewInit() {
    this.exampleDatabase = new ExampleHttpDatabase(this._httpClient);

    // If the user changes the sort order, reset back to the first page.
    this.sort.sortChange.subscribe(() => this.paginator.pageIndex = 0);

    merge(this.sort.sortChange, this.paginator.page)
      .pipe(
        startWith({}),
        switchMap(() => {
          this.isLoadingResults = true;
          return this.exampleDatabase!.getRepoIssues(
            this.sort.active, this.sort.direction, this.paginator.pageIndex);
        }),
        map(data => {
          // Flip flag to show that loading has finished.
          this.isLoadingResults = false;
          this.isRateLimitReached = false;
          this.resultsLength = data.total_count;

          return data.items;
        }),
        catchError(() => {
          this.isLoadingResults = false;
          // Catch if the GitHub API has reached its rate limit. Return empty data.
          this.isRateLimitReached = true;
          return observableOf([]);
        })
      ).subscribe(data => this.data = data);
  }
}

export interface GithubApi {
  items: GithubIssue[];
  total_count: number;
}

export interface GithubIssue {
  created_at: string;
  number: string;
  state: string;
  title: string;
}

/** An example database that the data source uses to retrieve data for the table. */
export class ExampleHttpDatabase {
  constructor(private _httpClient: HttpClient) {}

  getRepoIssues(sort: string, order: string, page: number): Observable<GithubApi> {
    const href = 'https://api.github.com/search/issues';
    const requestUrl =
        `${href}?q=repo:angular/components&sort=${sort}&order=${order}&page=${page + 1}`;

    return this._httpClient.get<GithubApi>(requestUrl);
  }
}