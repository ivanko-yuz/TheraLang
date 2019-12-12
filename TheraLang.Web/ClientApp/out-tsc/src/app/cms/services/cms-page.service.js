import { __awaiter, __decorate } from "tslib";
import { Injectable } from '@angular/core';
let CmsPageService = class CmsPageService {
    constructor(http) {
        this.http = http;
    }
    getPiranhaPageById(pageId) {
        return __awaiter(this, void 0, void 0, function* () {
            const allData = yield this.http.getPiranhaPageById(pageId).toPromise().then((data) => data);
            return allData;
        });
    }
};
CmsPageService = __decorate([
    Injectable()
], CmsPageService);
export { CmsPageService };
//# sourceMappingURL=cms-page.service.js.map