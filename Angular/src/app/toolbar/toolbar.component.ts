import { Component, OnInit, AfterViewInit } from '@angular/core';
import { HttpService } from '../project/http.service';
import { ProjectParticipationRequest } from '../project-participants/project-participation-request';
import { EventService } from '../project-participants/event-service';
import { RequestStatus } from '../request-status-enum';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.less'],
  providers: [HttpService]
})
export class ToolbarComponent implements OnInit, AfterViewInit {

  hasNotification = true;
  projectParticipation: ProjectParticipationRequest[];
  constructor(private httpService: HttpService, private evtSvc: EventService) { }

  ngOnInit() {
    this.httpService.getAllProjectParticipants().subscribe((data: ProjectParticipationRequest[]) => {
      this.projectParticipation = data;
      if ((this.projectParticipation.filter(x => x.status === RequestStatus.New)).length === 0) {
        this.hasNotification = false;
      }
    });
  }

  ngAfterViewInit(): void {
    this.evtSvc.childEventListner().subscribe(info => {
      this.hasNotification = false;
    });
  }
}
