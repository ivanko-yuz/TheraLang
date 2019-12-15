export class Project {
    constructor(
        public id?: number,
        public name?: string,
        public description?: string,
        public details?: string,
        public projectStart?: Date,
        public projectEnd?: Date,
        public typeId?: number,
        public isActive?: boolean
        ) { }
}
