export class User {
    id: number;
    firstName: string;
    lastName: string;
    shortInformation: string;
    imageURl: string;
    email: string;
    resources: any[];
}

export class UserPageViewModel {
  userList: User[];
  countOfItems: number;
}
