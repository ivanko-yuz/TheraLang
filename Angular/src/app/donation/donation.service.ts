import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable()
export class DonationService{
  
    constructor(private http: HttpClient){ }
      
     private url = "https://localhost:44353/api/";
     
     getCheckoutModel(donationAmount: string, projectId: number){
         debugger
        return this.http.get(`${this.url}payment/${donationAmount}/${projectId}`);
    }

    getLiqpayResponse(donationId: string){
        return this.http.get(`${this.url}result/${donationId}`);
    }
    
}