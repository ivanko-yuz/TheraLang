import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { NewsService } from 'src/app/core/http/news/news.service';
import { Router } from '@angular/router';
import { NewsCreate } from 'src/app/shared/models/news/newsCreate';
import { TranslateService } from '@ngx-translate/core';
import { NotificationService } from 'src/app/core/services/notification/notification.service';
import { Resource } from 'src/app/shared/models/resource/resource';
import { FileInput } from 'ngx-material-file-input';

@Component({
  selector: 'app-news-create',
  templateUrl: './news-create.component.html',
  styleUrls: ['./news-create.component.less']
})
export class NewsCreateComponent implements OnInit {

  public newsForm: FormGroup;

  constructor(
    private service:NewsService,
    private router: Router,
    private translate: TranslateService,
    private notificationService: NotificationService
    )
    {
    this.newsForm = new FormGroup({
      "title":new FormControl("",[Validators.required,Validators.maxLength(250), Validators.minLength(3)]),
      "text":new FormControl("", [Validators.required,Validators.maxLength(10000), Validators.minLength(5)]),
      "previewImage":new FormControl(null,[Validators.required,Validators.max(1)]),
      "contentImages":new FormControl(null)
    });
  }

  ngOnInit() {
  }

  initializeForm() {
    this.newsForm.setValue({
      title: "",
      text: "",
      previewImage: null,
      contentImages: null
    });
  }

  onSubmit() {
    if (this.newsForm.invalid) {
      const controls = this.newsForm.controls;
      Object.keys(controls).forEach(controlName =>
        controls[controlName].markAsTouched()
      );
      return;
    }
    else {
      const formData = new FormData();
      const prev_img: FileInput = this.newsForm.get('previewImage').value;
      const cont_imgs: FileInput = this.newsForm.get('contentImages').value;
      const file = prev_img.files[0];
      const files = cont_imgs.files;
      const news = this.newsForm.value as NewsCreate;
      formData.append("title", news.title);
      formData.append("text", news.text);
      formData.append("mainImage", file);
      if (files.length > 0) {
        for (let i = 0; i < files.length; i++) {
          formData.append('contentImages', files[i]);
        }
      }
      this.service.createNews(formData).subscribe(
        async (msg: string) => {
          msg = await this.translate
            .get("common.created-successfully")
            .toPromise();
          this.notificationService.success(msg);
          this.router.navigateByUrl("/news");
        },
        async error => {
          console.log(error);
          this.notificationService.warn(
            await this.translate.get("common.wth").toPromise()
          );
        })
      this.router.navigate(["/news/create"]);
    }
  }

}
