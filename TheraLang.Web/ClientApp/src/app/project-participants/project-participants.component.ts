import { Component, OnInit, ViewChild } from '@angular/core';
import { ProjectParticipationRequest } from './project-participation-request';
import { EventService } from './event-service';
import { MatTableDataSource, MatPaginator } from '@angular/material';
import { ProjectParticipantService } from './project-participant.service';
import { ProjectParticipationRequestStatus } from '../shared/enums/project-participation-request-status.enum';


@Component({
  selector: 'app-project-participants',
  templateUrl: './project-participants.component.html',
  styleUrls: ['./project-participants.component.less']
})
export class ProjectParticipantsComponent implements OnInit {

  projectParticipationRequest = new MatTableDataSource<ProjectParticipationRequest>();
  showActionButtons: boolean = true;
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  displayedColumns: string[] = ['createdById', 'role', 'projectId', 'status', 'actions'];

  constructor(private participantService: ProjectParticipantService, private eventService: EventService) { }

  ngOnInit() {
    this.participantService.getAllProjectParticipants().subscribe((projectParticipants: ProjectParticipationRequest[]) => {
      this.projectParticipationRequest.data = projectParticipants;
      this.projectParticipationRequest.filterPredicate = (projectParticipant: ProjectParticipationRequest, filter: string) =>
        projectParticipant.status.toString() === filter;
      this.projectParticipationRequest.paginator = this.paginator;
      this.projectParticipationRequest.filter = ProjectParticipationRequestStatus.New.toString();
    });
  }

  loadPatricipants() {
    this.participantService.getAllProjectParticipants().subscribe((projectParticipants: ProjectParticipationRequest[]) => {
      this.projectParticipationRequest.data = projectParticipants;
      this.removeNotificationIcon();
    });
  }

  changeTab(tabPosition: number) {
    this.projectParticipationRequest.filter = this.changeFilter(tabPosition);
    this.showActionButtons = (tabPosition === ProjectParticipationRequestStatus.New) ? true : false;
  }

  changeFilter(tabPosition: number) {
    if (tabPosition === 1) {
      return ProjectParticipationRequestStatus.Approved.toString();
    }
    else if (tabPosition === 2) {
      return ProjectParticipationRequestStatus.Rejected.toString();
    }
    else {
      return ProjectParticipationRequestStatus.New.toString();
    }
  }

  changeStatus(status: string, projectParticipant: ProjectParticipationRequest) {
    projectParticipant.status = (status === 'approved') ? ProjectParticipationRequestStatus.Approved : ProjectParticipationRequestStatus.Rejected;
    this.participantService.changeParticipationStatus(projectParticipant.id, projectParticipant.status).subscribe(data => {
      this.loadPatricipants();
    });
  }

  removeNotificationIcon() {
    if (this.projectParticipationRequest.filteredData.length === 0) {
      this.eventService.emitChildEvent();
    }
  }

}

