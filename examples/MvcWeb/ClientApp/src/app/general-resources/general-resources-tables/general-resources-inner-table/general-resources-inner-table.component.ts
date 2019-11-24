import { Component, OnInit, ViewChild, Input} from '@angular/core';
import { MatTableDataSource, MatPaginator, PageEvent } from '@angular/material';
import { Resource } from 'src/app/general-resources/resource-models/resource';
import { ResourceService } from 'src/app/project-info/resources-table-for-project/resources-table/resource.service';
import * as Constants  from '../../../shared/constants/resources-table';

@Component({
  selector: 'app-general-resources-inner-table',
  templateUrl: './general-resources-inner-table.component.html',
  styleUrls: ['./general-resources-inner-table.component.less']
})
export class GeneralResourcesInnerTableComponent implements OnInit {
  @Input() resourcesCategoryId: number;
  resources: Resource[];
  dataSource: MatTableDataSource<Resource>;
  showTable = false;
  allResourcesCount: number;
  columnsPerPage =  Constants.ResourcesTableConstants.COLUMNS_PER_PAGE;
  pageSizeOptions = Constants.ResourcesTableConstants.PAGE_SIZE_OPTIONS;
  displayedColumns: string[] = ['id', 'name', 'date', 'description'];
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;

  constructor(public resourceService: ResourceService) { }

  async ngOnInit() {
    this.resources = await this.resourceService.getResourcesByCategoryId(this.resourcesCategoryId ,
      Constants.ResourcesTableConstants.PAGE_NUMBER, Constants.ResourcesTableConstants.COLUMNS_PER_PAGE
    );

    this.allResourcesCount = await this.resourceService.getResourcesCountByCategoryId(this.resourcesCategoryId);
    this.dataSource = new MatTableDataSource(this.resources);
    this.dataSource.paginator = this.paginator;
    this.showTable = true;
  }

  async pageChanged(event: PageEvent) {
    this.resources = await this.resourceService.getResourcesByCategoryId(this.resourcesCategoryId ,
      event.pageIndex + 1, event.pageSize
    );

    this.allResourcesCount = await this.resourceService.getResourcesCountByCategoryId(this.resourcesCategoryId);
    this.dataSource = new MatTableDataSource(this.resources);
    this.dataSource.paginator = this.paginator;
  }
}
