import { Injectable } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Resource } from '../resource-models/resource';
import { NotificationService } from '../../shared/services/notification.service';
import { resourсeUrl, categoryUrl } from '../../shared/api-endpoint.constants';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class ResourceCreateService {

  private resourceUrl = resourсeUrl;
  private categoryUrl = categoryUrl;

  constructor(private formBuilder : FormBuilder,
      private notificationService : NotificationService,
      private http: HttpClient){

      }

  public resourceForm = this.formBuilder.group({
      id : [null],
      name : ['', [Validators.required, Validators.maxLength(50)]],
      description : ['', [Validators.required, Validators.maxLength(5000)]],
      url : [''],
      fileName : [''],
      file: [null],
      categoryId : [null, Validators.required],
  })

  initializeForm(){
      this.resourceForm.setValue({
          id : null,
          name : '',
          description : '',
          url : '',
          fileName : '',
          file : File,
          categoryId : null,
      });
  }

  postResource(resource : Resource){ 
      return this.http.post(this.resourceUrl +'/' + 'create', resource);
  }

  putResource(resource : Resource){
      return this.http.put(this.resourceUrl +'/' + 'update', resource);
  }

  getCategories(){
      return this.http.get(this.categoryUrl +'/' + 'get');
  }

  populateForm(resource){
      this.resourceForm.setValue(resource);
  }

  addResource(resource : Resource){
      this.postResource(resource).subscribe(
          response => {
              this.notificationService.success("Ресурс створено!");
          },
          error => {
              this.notificationService.warn("Помилка");
          });
  }

  updateResource(resource : Resource){
      this.putResource(resource).subscribe(
          response => {
              this.notificationService.success("Ресурс оновлено!");
          },
          error => {
              this.notificationService.warn("Помилка");
          });
  }
}
