import { Component, OnInit } from '@angular/core';
import { Resource } from '../general-resources/resource-models/resource';
import { ResourceService } from '../project-info/resources-table-for-project/resources-table/resource.service';
import { GeneralResourcesComponent } from '../general-resources/general-resources.component';
import { Observable, Subject } from 'rxjs';
import { FormControl } from '@angular/forms';
import { map, startWith } from 'rxjs/operators';
import { MatAutocompleteModule } from '@angular/material/autocomplete';

@Component({
  selector: 'app-add-resources-to-project',
  templateUrl: './add-resources-to-project.component.html',
  styleUrls: ['./add-resources-to-project.component.less']
})

export class AddResourcesToProjectComponent implements OnInit {

  displayedColumns: string[] = ['id', 'name', 'actions'];
  myControl = new FormControl();
  options: string[] = ['One', 'Two', 'Three'];
  filteredOptions: Observable<string[]>;

  ngOnInit() {
    debugger
    this.filteredOptions = this.myControl.valueChanges
      .pipe(
        startWith(''),
        map(value => this._filter(value))
      );
  }

  private _filter(value: string): string[] {
    const filterValue = value.toLowerCase();

    return this.options.filter(option => option.toLowerCase().includes(filterValue));
  }
}