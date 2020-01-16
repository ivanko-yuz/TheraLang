import { Injectable } from "@angular/core";
import { HttpService } from "../../http/http/http.service";
import { ResourceCategory } from "../../../shared/models/resource/resource-category";

@Injectable()
export class ResourceCategoriesService {
  resourceCategories: ResourceCategory[];

  constructor(private http: HttpService) {}

  getResourceCategories(
    withAssignedResources: boolean
  ): Promise<ResourceCategory[]> {
    const categories = this.http
      .getResourceCategories(withAssignedResources)
      .toPromise()
      .then((category: ResourceCategory[]) => {
        this.resourceCategories = category;
        return category;
      });
    return categories;
  }
}
