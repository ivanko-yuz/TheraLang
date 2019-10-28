import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpService } from '../project/http.service';
import { Project } from '../project/project';

@Component({
  selector: 'app-project-info',
  templateUrl: './project-info.component.html',
  styleUrls: ['./project-info.component.less'],
  providers:[HttpService]
})
export class ProjectInfoComponent implements OnInit {

  constructor(private route: ActivatedRoute,private http:HttpService) { }

  projectInfo : Project;

  ngOnInit() {
    this.route.paramMap.subscribe(params=>{
      let id = +params.get('id');
      this.http.getProjectInfo(id).subscribe((data:Project) => this.projectInfo=data);
    });
  }

}
