import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormGroup, Validators, FormControl } from '@angular/forms';
import { Newpage } from 'src/app/shared/models/new_page/newpage';
import { PageService } from '../../shared/services/page.service';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-edit-page',
  templateUrl: './edit-page.component.html',
  styleUrls: ['./edit-page.component.less']
})
export class EditPageComponent implements OnInit {
  page: Newpage;
  form = new FormGroup({
    header: new FormControl('', [Validators.required, Validators.maxLength(60)]),
    menuName: new FormControl('', [Validators.required, Validators.maxLength(60)]),
    content: new FormControl('', Validators.required)
  });

  constructor(
    private pageService: PageService,
    private router: Router,
    private route: ActivatedRoute
  ) {
  }

  ngOnInit() {
    this.route.params.pipe(
      switchMap((params: Params) => {
        return this.pageService.getPageById(params['id']);
      })
    ).subscribe((page: Newpage) => {
      this.page = page
      this.form.controls.header.setValue(page.header);
      this.form.controls.content.setValue(page.content);
      this.form.controls.menuName.setValue(page.menuName);
    });
  }

  onCancel() {
    this.router.navigate(['admin', 'sitemap']);
  }

  hasError(controlName: string, errorName: string) {
    return this.form.controls[controlName].hasError(errorName);
  }

  submit() {
    if (this.form.invalid) {
      return;
    }

    this.pageService.updatePage({
      ...this.page,
      header: this.form.value.header,
      menuName: this.form.value.menuName,
      content: this.form.value.content
    });
  }
}
