export class SiteMap {
  pageTypeName: string;
  permalink: string;
  header: string;
  menuTitle: string;
  id: number;
  level: number;
  subPages: SiteMap[];
  parentId: number;
}
