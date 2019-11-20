export class Project {
    constructor(
        public id: number,
        public name: string,
        public description: string,
        public details: string,
        public projectBegin: Date,
        public projectEnd: Date,
        public isActive: boolean
    ) { }
}
