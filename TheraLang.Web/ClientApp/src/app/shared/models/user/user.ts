import DateTimeFormat = Intl.DateTimeFormat;

export class User {
    id: number;
    firstName: string;
    lastName: string;
    shortInformation: string;
    imageURl: string;
    email: string;
    resources: any[];
    city: string;
    birthDay: Date;
    phoneNumber: string;
}

export class UserPageViewModel {
  userList: User[];
  countOfItems: number;
}
