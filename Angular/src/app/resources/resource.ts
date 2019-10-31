export class Resource {
    constructor(
        public id : number,
        public name : string,
        public dateTime : Date,
        public description : string,
        public resourceCategoryId : number
    ) { }
}