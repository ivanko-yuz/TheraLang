import { Component, OnInit, ViewChild } from '@angular/core';
import { HttpService } from '../project/http.service';
import { ProjectParticipationRequest, Request } from './project-participation-request';
import { EventService } from './event-service';
import { MatTableDataSource, MatPaginator } from '@angular/material';


@Component({
  selector: 'app-project-participants',
  templateUrl: './project-participants.component.html',
  styleUrls: ['./project-participants.component.less']
})
export class ProjectParticipantsComponent implements OnInit {

  projectParticipationRequest;
  showActionButtons: boolean = true;
  showHead: boolean = true;
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  displayedColumns: string[] = ['name', 'userId', 'projectId', 'status', 'actions'];

  constructor(private httpService: HttpService, private eventService: EventService) { }

  ngOnInit() {
    this.httpService.getAllProjectParticipants().subscribe((projectParticipants: ProjectParticipationRequest[]) => {
      this.projectParticipationRequest = new MatTableDataSource<ProjectParticipationRequest>(projectParticipants);
      this.projectParticipationRequest.filterPredicate = (projectParticipant: ProjectParticipationRequest, filter: string) => projectParticipant.status.toString() == filter;
      this.projectParticipationRequest.paginator = this.paginator;
      this.projectParticipationRequest.filter = Request.New.toString();
    });

  }

  load() {
    this.httpService.getAllProjectParticipants().subscribe((projectParticipants: ProjectParticipationRequest[]) => {
      this.projectParticipationRequest.data = projectParticipants;
      this.removeNotificationIcon();
    });

  }

  changeTab(tabPosition: number) {
    this.projectParticipationRequest.filter = tabPosition.toString();
    this.showActionButtons = (tabPosition === Request.New) ? true : false;

  }

  changeStatus(status: number, projectParticipant: ProjectParticipationRequest) {
    projectParticipant.status = status;
    this.httpService.changeParticipationStatus(projectParticipant.id, projectParticipant.status).subscribe(data => {
      this.load();
    });

  }

  removeNotificationIcon() {
    if (this.projectParticipationRequest.filteredData.length === 0) {
      this.eventService.emitChildEvent();
    }
    
  }


}

