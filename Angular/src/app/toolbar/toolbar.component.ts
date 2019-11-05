import { Component, OnInit, AfterViewInit, Output, ViewChild } from '@angular/core';
import { HttpService } from '../project/http.service';
import { ProjectParticipationRequest } from '../project-participants/project-participation-request';
import { ProjectParticipantsComponent } from '../project-participants/project-participants.component';
import { EventService } from '../project-participants/event-service';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.less'],
  providers:[HttpService]
})
export class ToolbarComponent implements OnInit,AfterViewInit{

  haveNotifications: boolean = true;
  reqs: ProjectParticipationRequest[];
  constructor(private httpService:HttpService,private evtSvc: EventService) { }

  ngOnInit() {
    this.httpService.getAllProjectParticipants().subscribe((data: ProjectParticipationRequest[])=>{
    this.reqs=data;
    if((this.reqs.filter(x=>x.status === 0)).length < 1){
      this.haveNotifications = false;
      // this.evtSvc.childEventListner().subscribe(info =>{
      //   debugger
      //   console.log(info);
      //   this.haveNotifications = false;
      //  });
    }
  });

  }
  
  // @ViewChild(ProjectParticipantsComponent, {static: false})

  //  set request(v: ProjectParticipantsComponent) {
  //   v.requestForParentEvent.subscribe(x=>this.haveNotifications = false);
  // }

  // ngAfterViewInit(): void {  
  //     this.evtSvc.childEventListner().subscribe(info => {
  //       this.httpService.getAllProjectParticipants().subscribe((data: ProjectParticipationRequest[]) => {
  //         this.reqs = data;
  //         if ((this.reqs.filter(x => x.status === 0)).length < 2) {
  //         console.log(info);
  //         this.haveNotifications = false;
  //       }
  //       });      
  //       });    
  // }

//   ngAfterViewInit(): void {  
//     this.evtSvc.childEventListner().subscribe(info => {
//         if(info.filteredData.length < 2){
//         this.haveNotifications = false;
//         }
//       }
         
//       );    
// }



   ngAfterViewInit(): void {
    // this.httpService.getAllProjectParticipants().subscribe((data: ProjectParticipationRequest[])=>{
    //   this.reqs=data;
    //   // if((this.reqs.filter(x=>x.status === 0)).length < 4){
    //   // }
    //   }
    // );
         this.evtSvc.childEventListner().subscribe(info =>{
          debugger
          console.log(info);
          this.haveNotifications = false;
         });
   }


  //   debugger
  //   this.request.requestForParentEvent.subscribe(x=>this.haveNotifications = false);
  //   // this.request.sub.subscribe(x=> this.httpService.getAllProjectParticipants().subscribe((data: ProjectParticipationRequest[])=>{
  //   //   this.reqs=data;
  //   //   if((this.reqs.filter(x=>x.status === 0)).length < 1){
  //   //     this.haveNotifications = false;
  //   //   }
  //   // }));
   

  }
