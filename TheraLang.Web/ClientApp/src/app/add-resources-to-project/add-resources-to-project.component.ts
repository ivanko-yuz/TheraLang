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
  displayedColumns: string[] = ['description', 'actions'];

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
    this.resources = await this.service.getAllResourcesNotAttached(this.data.id);
    this.filteredResources = this.resources;
  }

  Add(_resourceId: number): Observable<any> {
    const newResourceToProject = new ResourceToProject();
    newResourceToProject.resourceId = _resourceId;
    newResourceToProject.projectId = this.data.id;
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