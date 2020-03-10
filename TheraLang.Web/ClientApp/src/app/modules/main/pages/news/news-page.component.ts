import { Component, OnInit } from '@angular/core';
import { NewsPreview } from 'src/app/shared/models/news/newsPreview';
import { NewsDetailsComponent } from './news-details/news-details.component';
import { NewsService } from 'src/app/core/http/news/news.service';
import { UserService } from 'src/app/core/auth/user.service';
import { Roles } from 'src/app/shared/models/roles/roles';

@Component({
  selector: 'app-news-page',
  templateUrl: './news-page.component.html',
  styleUrls: ['./news-page.component.less']
})
export class NewsPageComponent implements OnInit {

  newsList: NewsPreview[];

  constructor(
    private service: NewsService,
    public userService: UserService) { }

  ngOnInit() {
    this.getAllNews();
  }

  getAllNews() {
    this.service.getAllNews()
      .subscribe((data: NewsPreview[]) => this.newsList = data);
  }

  isAdmin() {
    return this.userService.isRole(Roles.Admin);
  }
  
}
