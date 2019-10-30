export class Resource {
    constructor(
        public id : number,
        public dateTime : Date,
        public description : string,
        public resourceCategoryId : number
    ) { }
}