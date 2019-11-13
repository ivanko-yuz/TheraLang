export class ToolbarItem {
  route: string;
  title: string;
  subItems: ToolbarItem[];
  constructor(route: string, title: string, subItems?: ToolbarItem[]) {
    this.route = route;
    this.title = title;
    this.subItems = subItems ? subItems : [];
  }
}
