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
    birthdayDate: Date;
    phoneNumber: string;
}

export class UserPageViewModel {}
