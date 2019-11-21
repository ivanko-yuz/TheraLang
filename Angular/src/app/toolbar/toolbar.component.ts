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

  hasNotification: boolean = false;
  projectParticipation: ProjectParticipationRequest[];
  constructor(private httpService: HttpService, private eventService: EventService) { }

  ngOnInit() {
    this.httpService.getAllProjectParticipants().subscribe((projectParticipation: ProjectParticipationRequest[]) => {
      this.projectParticipation = projectParticipation;
      if ((this.projectParticipation.filter(x => x.status === RequestStatus.New)).length > 0) {
        this.hasNotification = true;
      }
    });
  }

  ngAfterViewInit(): void {
    this.eventService.childEventListner().subscribe(click => {
      this.hasNotification = false;
    });
  }
}
