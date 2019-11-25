import { ResourceProjects } from './resource-projects';
import { User } from './user';
import { ResourceCategory } from './resource-category';

export class Resource {
    user: User;
    name: string;
    description: string;
    url?: any;
    file?: any;
    categoryId: number;
    resourceCategory: ResourceCategory;
    resourceProjects: ResourceProjects;
    id: number;
    createdById: number;
    updatedById: number;
    createdDateUtc: Date;
    updatedDateUtc?: any;
}
