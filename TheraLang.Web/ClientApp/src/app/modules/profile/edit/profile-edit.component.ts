import { Component, OnInit } from "@angular/core";
import { TranslateService } from "@ngx-translate/core";
import { NotificationService } from "src/app/core/services/notification/notification.service";
import { DialogService } from "src/app/core/services/dialog/dialog.service";
import { Router, ActivatedRoute } from "@angular/router";
import {FormBuilder, FormControl, Validators} from "@angular/forms";
import {User} from "../../../shared/models/user/user";
import {UserService} from "../../../core/services/user/user.service";

@Component({
  selector: "app-profile-edit",
  templateUrl: "./profile-edit.component.html",
  styleUrls: ["./profile-edit.component.less"]
})
export class ProfileEditComponent implements OnInit {
  imageSrc: string | ArrayBuffer;
  user: User;

  constructor(
    private notificationService: NotificationService,
    private dialog: DialogService,
    private translate: TranslateService,
    private router: Router,
    private route: ActivatedRoute,
    private fb: FormBuilder,
    private userService: UserService,
  ) {}

  EditProfileForm = this.fb.group({
    FirstName: [
      "",
      [Validators.required, Validators.minLength(2), Validators.maxLength(50)]
    ],
    LastName: [
      "",
      [Validators.required, Validators.minLength(2), Validators.maxLength(50)]
    ],
    Image: [
      null,
    ],
    BirthDay: [
      ""
    ],
    ShortInformation: [
      ""
    ],
    PhoneNumber: [
      "",
      [Validators.pattern(/^\(?([0-9]{3})\)?([ .-]?)([0-9]{3})\2([0-9]{4})$/g)]
    ],
    City: [
      ""
    ]
  });
  maxDate: Date;

  ngOnInit() {
    this.maxDate = new Date();
    this.userService.me().subscribe(value => {
      this.user = value as User;
      this.EditProfileForm.setValue({
        FirstName: this.user.firstName,
        LastName: this.user.lastName,
        Image: null,
        BirthDay: this.user.birthDay === null ? "" : this.user.birthDay,
        PhoneNumber: this.user.phoneNumber === null ? "" : this.user.phoneNumber,
        City: this.user.city === null ? "" : this.user.city,
        ShortInformation: this.user.shortInformation === null ? "" : this.user.shortInformation,
      });
    });
  }

  onSubmit() {
    if (this.EditProfileForm.invalid) {
      const controls = this.EditProfileForm.controls;
      Object.keys(controls).forEach(controlName =>
        controls[controlName].markAsTouched()
      );

      return;
    }

    this.userService.editProfile(this.EditProfileForm.value).subscribe(() => {
      this.router.navigateByUrl("/profile");
    });
  }

  onFileChange(event) {
    if (event.target.files && event.target.files.length) {
      const [file] = event.target.files;
      const reader = new FileReader();
      reader.onload = e => this.imageSrc = reader.result;

      reader.readAsDataURL(file);

      this.EditProfileForm.patchValue({
        Image: file,
      });
    }
  }

  avatarChange() {
    document.getElementById("input-file-id").click();
  }
}
