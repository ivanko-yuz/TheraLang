import { Resource } from '../../../general-resources/resource-models/resource';
import { Component, Input, ViewChild, AfterViewInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material';
import * as Constants from '../../../shared/constants/resources-table';
import { ResourcesToProjectService } from 'src/app/add-resources-to-project/resources-to-project.service';
import { ResourceToProject } from 'src/app/add-resources-to-project/resource-to-project';

@Component({
  selector: 'app-resources-internal-table',
  templateUrl: './resources-internal-table.component.html',
  styleUrls: ['./resources-internal-table.component.less'],
})

export class ResourcesInternalTableComponent implements AfterViewInit {
  @Input() dataSource: MatTableDataSource<Resource>;
  displayedColumns: string[] = ['id', 'name', 'date', 'description', 'actions'];
  @Input() lengthDataArrForDataSource;
  pageSize: number;
  pageSizeOptions: number[];
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;

  constructor(
    private resourcesToProjectService: ResourcesToProjectService,
  ) { }

  ngAfterViewInit() {
    this.pageSize = Constants.ResourcesTableConstants.COLUMNS_PER_PAGE;
    this.pageSizeOptions = Constants.ResourcesTableConstants.PAGE_SIZE_OPTIONS;
    this.dataSource.paginator = this.paginator;
  }

  onDelete(resourceId: number) {
    const resourceToProject = new ResourceToProject();
    resourceToProject.resourceId = resourceId;
    this.resourcesToProjectService.delete(resourceToProject);

  }
}

