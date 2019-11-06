import { Component, OnInit, ViewChild } from '@angular/core';
import { HttpService } from '../project/http.service';
import { ProjectParticipationRequest } from './project-participation-request';
import { HttpClient } from '@angular/common/http';
import { EventService } from './event-service';
import { MatTableDataSource, MatPaginator} from '@angular/material';


@Component({
  selector: 'app-project-participants',
  templateUrl: './project-participants.component.html',
  styleUrls: ['./project-participants.component.less'],
  providers:[HttpService]
})
export class ProjectParticipantsComponent implements OnInit {

  projectParticipationRequest;
  showActionButtons: boolean = true;
  showHead: boolean = true;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  displayedColumns: string[] = ['name','userId', 'projectId','status','actions'];

  constructor(private httpService:HttpService, private evtSvc: EventService) { }

  ngOnInit() {
    this.httpService.getAllProjectParticipants().subscribe((data: ProjectParticipationRequest[]) =>{
     this.projectParticipationRequest = new MatTableDataSource<ProjectParticipationRequest>(data);
     this.projectParticipationRequest.filterPredicate = (data: ProjectParticipationRequest,filter:string)=> data.status.toString() == filter;
     this.projectParticipationRequest.paginator = this.paginator;
    this.projectParticipationRequest.filter = '0';
    });

  }


  load(){
      this.httpService.getAllProjectParticipants().subscribe((data: ProjectParticipationRequest[]) =>{
      this.projectParticipationRequest.data = data; 
      this.removeNotificationIcon();   
     });
   
  }
  
  changeTab(tabNumber:number){
    this.projectParticipationRequest.filter = tabNumber.toString();

    if(tabNumber !== 0){
    this.showActionButtons = false;
    }
    else{
      this.showActionButtons = true;
    }
  }

  changeStatus( status: number ,request: ProjectParticipationRequest)
  {
    request.status = status;
    this.httpService.changeParticipationStatus(request.id, request.status).subscribe(data=>{ 
      this.load(); 
      });
   
  }

  removeNotificationIcon(){
     if(this.projectParticipationRequest.filteredData.length === 0){
      this.evtSvc.emitChildEvent();   
    }
    
  }








}

