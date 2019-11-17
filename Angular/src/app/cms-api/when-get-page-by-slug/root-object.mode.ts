import { Block } from './block.model';
import { Hero } from './hero.model';

export class RootObject {
    hero: Hero;
    isStartPage: boolean;
    siteId: string;
    contentType: string;
    parentId: string;
    sortOrder: number;
    navigationTitle?: any;
    isHidden: boolean;
    redirectUrl?: any;
    redirectType: number;
    originalPageId?: any;
    blocks: Block[];
    slug: string;
    permalink: string;
    metaKeywords?: any;
    metaDescription?: any;
    route: string;
    published: string;
    id: string;
    typeId: string;
    title: string;
    created: string;
    lastModified: string;
}
