import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { NewsDetails } from 'src/app/shared/models/news/newsDetails';
import { NewsService } from 'src/app/core/http/news/news.service';
import { ActivatedRoute, Router } from '@angular/router';
import { FileInput } from 'ngx-material-file-input';
import { NewsEdit } from 'src/app/shared/models/news/newsEdit';
import { TranslateService } from '@ngx-translate/core';
import { NotificationService } from 'src/app/core/services/notification/notification.service';

@Component({
  selector: 'app-news-edit',
  templateUrl: './news-edit.component.html',
  styleUrls: ['./news-edit.component.less']
})
export class NewsEditComponent implements OnInit {

  public editForm: FormGroup;
  newsId:number;
  imagesArray: string[][] = [];
  newsDetails: NewsDetails;
  contentImages: string[] = [];
  mainImage: string;

  constructor(
    private route: ActivatedRoute,
    private service: NewsService,
    private router: Router,
    private translate: TranslateService,
    private notificationService: NotificationService
  ) {
    this.editForm = new FormGroup({
      "title":new FormControl("",[Validators.required,Validators.maxLength(250), Validators.minLength(3)]),
      "text":new FormControl("", [Validators.required,Validators.maxLength(10000), Validators.minLength(5)]),
      "newPreviewImage":new FormControl(null,[Validators.required,Validators.max(1)]),
      "newContentImages":new FormControl(null)
    });
   }

  ngOnInit() {
    this.newsId = parseInt(this.route.snapshot.paramMap.get("newsId"));
    this.service.getNewsById(this.newsId).subscribe((data: NewsDetails) => {
      this.newsDetails = data;
      this.newsDetails.contentImageUrls.map(image => {
        this.contentImages.push(image);
      });
      this.slice();
      this.editForm.controls["title"].setValue(this.newsDetails.title)      
      this.editForm.controls["text"].setValue(this.newsDetails.text)     
      this.editForm.controls["newPreviewImage"].setValue(File) 
      this.mainImage=this.newsDetails.mainImageUrl
    });   
  }
  

  slice(){
    var start = 0 
    var i=0 
    if(this.imagesArray.length>0)
      this.imagesArray.length=0
    while(start<this.contentImages.length+2)
    {
      let end = start + 3 > this.contentImages.length ? this.contentImages.length + 1 : start + 3;
      this.imagesArray.push(this.contentImages.slice(start,end));
      start+=3
    }   
  }

  onRemove(toRemoveUrl: string){
    console.log(toRemoveUrl)
    const index = this.contentImages.indexOf(toRemoveUrl)
    if (index > -1)
      this.contentImages.splice(index, 1);
    this.slice()
  }

  onRemoveMainImg(){
    this.mainImage=null
    this.editForm.controls["newPreviewImage"].setValue(null)
  }

  onSubmit() {
    if (this.editForm.invalid) {
      const controls = this.editForm.controls;
      Object.keys(controls).forEach(controlName =>
        controls[controlName].markAsTouched()
      );
      return;
    }
    else {
      const formData = new FormData();
      const prev_img: FileInput = this.editForm.get('newPreviewImage').value;
      const cont_imgs: FileInput = this.editForm.get('newContentImages').value;
      let file = null;
      if(prev_img.files){
        file = prev_img.files[0]
      }
      let files:File[]=[]
      if(cont_imgs){
        files = cont_imgs.files;
      }
      const news = this.editForm.value as NewsEdit;
      formData.append("title", news.title);
      formData.append("text", news.text);

      if(file){
        formData.append("newMainImage", file);
      }
      else{
        formData.append("newMainImage", null);
      }

      if (files.length > 0) {
        for (let i = 0; i < files.length; i++) {
          formData.append('addedContentImages', files[i]);
        }
      }

      if (this.contentImages.length > 0) {
        for (let i = 0; i < this.contentImages.length; i++) {
          formData.append('notDeletedContentImageUrls', this.contentImages[i]);
        }
      }else{
        formData.append('notDeletedContentImageUrls', null);
      }

      formData.append("uploadedMainImageUrl", this.newsDetails.mainImageUrl);

      this.service.editNews(this.newsId,formData).subscribe(
        async (msg: string) => {
          msg = await this.translate
            .get("common.edited-successfully")
            .toPromise();
          this.notificationService.success(msg);
          this.router.navigateByUrl(`/news/details/${this.newsId}`);
        },
        async error => {
          console.log(error);
          this.notificationService.warn(
            await this.translate.get("common.wth").toPromise()
          );
        })
      this.router.navigate([`/news/details/${this.newsId}`]);
    }
  }
}
