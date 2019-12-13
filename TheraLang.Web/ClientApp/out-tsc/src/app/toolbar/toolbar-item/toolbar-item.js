export class ToolbarItem {
    constructor(route, cmsRoute, title, subItems) {
        this.title = title;
        this.subItems = subItems ? subItems : [];
        this.permalink = route;
        this.cmsRoute = cmsRoute;
    }
}
//# sourceMappingURL=toolbar-item.js.map