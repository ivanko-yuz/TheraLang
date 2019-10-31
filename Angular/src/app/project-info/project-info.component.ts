import { Component, OnInit, ViewEncapsulation} from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpService } from '../project/http.service';
import { Project } from '../project/project';
import { Resource } from '../resources-table/resource';
import * as $ from 'jquery';
import { isNullOrUndefined } from 'util';

@Component({
  selector: 'app-project-info',
  templateUrl: './project-info.component.html',
  styleUrls: ['./project-info.component.less'],
  encapsulation: ViewEncapsulation.None,
  providers: [HttpService]
})
export class ProjectInfoComponent implements OnInit {

  constructor(private route: ActivatedRoute, private http: HttpService) { }

  projectInfo: Project;
  projectResources: Resource[];
  id: number;

  ngAfterViewInit() {
    $('#resTabId').hide(); }

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.id = +params.get('id');
      this.http.getProjectInfo(this.id).subscribe((data: Project) => this.projectInfo = data);
    });
  }

  getResources() {
      $('#resTabId').slideToggle('slow');
      if (isNullOrUndefined(this.projectResources)) {
      this.http.getAllResourcesById(this.id).subscribe((_data: Resource[]) => this.projectResources = _data);
    }

  }
}







