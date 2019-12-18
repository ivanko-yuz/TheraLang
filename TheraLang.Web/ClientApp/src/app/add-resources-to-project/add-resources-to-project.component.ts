import { Component, OnInit, Inject } from '@angular/core';
import { Resource } from '../general-resources/resource-models/resource';
import { Observable } from 'rxjs';
import { ResourcesToProjectService } from './resources-to-project.service';
import { ResourceToProject } from './resource-to-project';
import { NotificationService } from '../shared/services/notification.service';
import { DialogData } from '../project-info/resources-table-for-project/project-type/project-type.component';
import { MAT_DIALOG_DATA } from '@angular/material';

@Component({
  selector: 'app-add-resources-to-project',
  templateUrl: './add-resources-to-project.component.html',
  styleUrls: ['./add-resources-to-project.component.less']
})

export class AddResourcesToProjectComponent implements OnInit {
  resources: Resource[];
  filteredResources: Resource[];
  private _searchTerm: string;

  get searchTerm(): string {
    return this._searchTerm;
  }
  set searchTerm(value: string) {
    this._searchTerm = value;
    this.filteredResources = this.filterResources(value);
  }

  filterResources(searchString: string) {
    return this.resources.filter(resources =>
      resources.name.toLowerCase().indexOf(searchString.toLowerCase()) !== -1);
  }

  constructor(
    private service: ResourcesToProjectService,
    private notificationService: NotificationService,
    @Inject(MAT_DIALOG_DATA) public data: DialogData,

  ) { }

  async ngOnInit() {
    debugger
    // let var1 = new Resource();
    // var1.id = 1;
    // var1.name = 'some text1';
    // let var2 = new Resource();
    // var2.id = 2;
    // var2.name = 'some text2';
    // let var3 = new Resource();
    // var3.id = 3;
    // var3.name = 'some text3';
    // this.resources = new Array(var1, var2, var3);
    this.resources = await this.service.getAllResourcess()

    this.filteredResources = this.resources;
    debugger
  }

  Add(_resourceId: number): Observable<any> {
    debugger;
    const newResourceToProject = new ResourceToProject();
    newResourceToProject.resourceId = _resourceId;
    newResourceToProject.projectId = this.data.id;
    debugger;
    this.service.post(newResourceToProject).subscribe(
      response => {
        this.notificationService.success("Ресурс до проекту додано!");
      },
      error => {
        this.notificationService.warn("Помилка додавання ресурсу!");
      }
    );
    this.searchTerm = '';
    this.ngOnInit();
    return;
  }

  Delete(resourceToProject: ResourceToProject) {
    this.service.delete(resourceToProject).subscribe(
      response => {
        this.notificationService.success(
          "Ресурс з проекту видалено!"
        );
      },
      error => {
        this.notificationService.warn("Помилка видалення!");
      }
    );
  }

}