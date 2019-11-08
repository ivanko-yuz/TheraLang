export class Resource {
    constructor(
        public id: number,
        public name: string,
        public dateTime: Date,
        public description: string,
        public projectId: number,
        public resourceCategory: string
    ) { }
}
