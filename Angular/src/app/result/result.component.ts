import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { LiqPayResponseModel } from './liqay-response-model';
import { error } from 'util';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-result',
  templateUrl: './result.component.html',
  styleUrls: ['./result.component.less']
})
export class ResultComponent implements OnInit {
  response: LiqPayResponseModel;
  er: any;
  donationId: string;
  private url = "https://localhost:44353/api/";
  constructor(private http1: HttpClient,private route: ActivatedRoute) { }

  ngOnInit() {
    // this.http1.get(`${this.url}result/`).subscribe((responseData: LiqPayResponseModel) => {
    //   debugger
    //   this.response = responseData
    // },
    //  error =>       {
    //   this.er = <any>error;   
    // });

    this.route.paramMap.subscribe(params=>{
      this.donationId = params.get('donationId');
      debugger
      this.http1.get(`${this.url}result/${this.donationId}`).subscribe((responseData: LiqPayResponseModel) => {
        debugger
        this.response = responseData;
      
      });
    });
        
  }
}


