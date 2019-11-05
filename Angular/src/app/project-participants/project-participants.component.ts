import { Component, OnInit, Output, EventEmitter, ViewChild } from '@angular/core';
import { HttpService } from '../project/http.service';
import { ProjectParticipationRequest } from './project-participation-request';
import { HttpClient } from '@angular/common/http';
import { EventService } from './event-service';
import { MatTableDataSource, MatPaginator, MatTable } from '@angular/material';
import { DataRowOutlet } from '@angular/cdk/table';
import { Observable, Subscription } from 'rxjs';


@Component({
  selector: 'app-project-participants',
  templateUrl: './project-participants.component.html',
  styleUrls: ['./project-participants.component.less'],
  providers:[HttpService]
})
export class ProjectParticipantsComponent implements OnInit {

  // projectParticipationRequest: ProjectParticipationRequest[];
  projectParticipationRequest;
  // test: ProjectParticipationRequest[] = [];
  test;
  // filteredRequests: ProjectParticipationRequest[]=[];
  errorMessage:string;
  showButtons: boolean = true;
  showHead: boolean = true;

  constructor(private httpService:HttpService,private http: HttpClient,private evtSvc: EventService) { }
  private url2 = "https://localhost:44353/api/projectParticipants";
 

  ngOnInit() {
    this.httpService.getAllProjectParticipants().subscribe((data: ProjectParticipationRequest[]) =>{
     this.projectParticipationRequest = new MatTableDataSource<ProjectParticipationRequest>(data);
     this.projectParticipationRequest.filterPredicate = (data: ProjectParticipationRequest,filter:string)=> data.status.toString() == filter;
     this.projectParticipationRequest.paginator = this.paginator;
    this.projectParticipationRequest.filter = '0';
    });

  }

  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
 
  displayedColumns: string[] = ['userId', 'projectId','status','actions'];

  load(){
      this.httpService.getAllProjectParticipants().subscribe((data: ProjectParticipationRequest[]) =>{
      this.projectParticipationRequest.data = data; 
      this.callParentEvent();   
    // if(this.projectParticipationRequest.filteredData.length < 1){
    //   this.showHead = false;
    // }
    // else{
    //   this.showHead = true;
    // }
     });
   
  }
  
  getRequests(value:number){
    console.log(value);
   this.projectParticipationRequest.filter = value.toString();

    if(value !== 0){
    this.showButtons = false;

    }
    else{
      this.showButtons = true;
 
    }
    console.log(this.projectParticipationRequest);
  }

  changeStatus( status: number ,request: ProjectParticipationRequest)
  {
    request.status = status;
  
    this.http.put(this.url2 + '/' + request.id, request.status).subscribe(data=>{ 
     this.load(); 
     });
    
  }


  @Output() public requestForParentEvent = new EventEmitter();

  callParentEvent(){
    //  this.projectParticipationRequest.filterPredicate = (data: ProjectParticipationRequest)=> data.status === 0;
     if(this.projectParticipationRequest.filteredData.length === 0){
      // this.showHead = false;
      this.evtSvc.emitChildEvent();   
    }
    
  }








}

