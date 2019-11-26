import {CmsRoute} from './cms-route';
import {environment} from '../../../environments/environment';

export class ToolbarItem {
  title: string;
  subItems: ToolbarItem[];
  permalink: string;
  cmsRoute: CmsRoute;
  constructor(route: string, cmsRoute: CmsRoute, title: string, subItems?: ToolbarItem[]) {
    this.title = title;
    this.subItems = subItems ? subItems : [];
    this.permalink = route;
    this.cmsRoute = cmsRoute;
  }
}
