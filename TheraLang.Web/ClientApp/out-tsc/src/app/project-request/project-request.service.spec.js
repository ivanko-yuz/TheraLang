import { TestBed } from "@angular/core/testing";
import { HttpProjectService } from "./http-project.service";
describe("ProjectRequestService", () => {
    beforeEach(() => TestBed.configureTestingModule({}));
    it("should be created", () => {
        const service = TestBed.get(HttpProjectService);
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=project-request.service.spec.js.map