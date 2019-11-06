import { Component, OnInit, AfterViewInit} from '@angular/core';
import { HttpService } from '../project/http.service';
import { ProjectParticipationRequest } from '../project-participants/project-participation-request';
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
    if((this.reqs.filter(x=>x.status === 0)).length === 0){
      this.haveNotifications = false;

    }
  });

  }
  
   ngAfterViewInit(): void {
         this.evtSvc.childEventListner().subscribe(info =>{
          this.haveNotifications = false;
         });
   }
   
  }
