import { Component, OnInit, Input } from '@angular/core';
import { NewsDetails } from 'src/app/shared/models/news/newsDetails';
import { ActivatedRoute } from '@angular/router';
import { NewsService } from 'src/app/core/http/news/news.service';
import { map, delay } from 'rxjs/operators';
import { of } from 'rxjs';

@Component({
  selector: 'app-news-details',
  templateUrl: './news-details.component.html',
  styleUrls: ['./news-details.component.less']
})
export class NewsDetailsComponent implements OnInit {
  newsId : number;
  newsDetails : NewsDetails;
  contentImages: Array<object> = [];
  // =[{ 
  //   image: 'http://r.ddmcdn.com/s_f/o_1/cx_462/cy_245/cw_1349/ch_1349/w_720/APL/uploads/2015/06/caturday-shutterstock_149320799.jpg',
  //   thumbImage: 'http://r.ddmcdn.com/s_f/o_1/cx_462/cy_245/cw_1349/ch_1349/w_720/APL/uploads/2015/06/caturday-shutterstock_149320799.jpg'
  // }];
  values: any;
  

  constructor(private route: ActivatedRoute, private service:NewsService) { 
  }

  ngOnInit() {
    this.newsId= parseInt(this.route.snapshot.paramMap.get("newsId"));
    //console.log(this.newsId);
    this.getNewsById(this.newsId);
  }

  getNewsById(id : number){
      this.service.getNewsById(id).subscribe((data:NewsDetails)=>{
        this.newsDetails=data;
        //console.log(this.newsDetails);//Some error with downloading data from object when page loads, but service works well
        this.newsDetails.contentImageUrls.map(image => {
          this.contentImages.push({
            image: image,
            thumbImage: image
          });
        });
      });
      // const mapper = map((val) => { image: val; thumbImage: val });
      // this.newsDetails.contentImageUrls.forEach(img=>{
      //   this.contentImages.push(mapper(of(img)).subscribe(x=>console.log(x)));
      // })
      //console.log(this.values); 

  }
}
