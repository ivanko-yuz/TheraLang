import { __decorate } from "tslib";
import { Subject } from 'rxjs';
import { Injectable } from '@angular/core';
let EventService = class EventService {
    constructor() {
        this.childClickedEvent = new Subject();
    }
    emitChildEvent() {
        this.childClickedEvent.next();
    }
    childEventListner() {
        return this.childClickedEvent.asObservable();
    }
};
EventService = __decorate([
    Injectable()
], EventService);
export { EventService };
//# sourceMappingURL=event-service.js.map