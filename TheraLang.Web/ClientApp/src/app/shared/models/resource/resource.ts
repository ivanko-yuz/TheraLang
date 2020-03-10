import { ResourceProjects } from "./resource-projects";
import { ResourceCategory } from "./resource-category";
import { User } from "../user/user";

export interface Resource {
  user: User;
  name: string;
  description: string;
  url?: string;
  file?: any;
  categoryId: number;
  authorName?: string;
  resourceCategory?: ResourceCategory;
  resourceProjects?: ResourceProjects;
  id: number;
  createdById: string;
  updatedById: string;
  createdDateUtc: Date;
  updatedDateUtc?: Date;
}
