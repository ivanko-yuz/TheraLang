import { TestBed } from "@angular/core/testing";
import { HttpProjectService } from "./http-project.service";

describe("ProjectRequestService", () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it("should be created", () => {
    const service: HttpProjectService = TestBed.get(HttpProjectService);
    expect(service).toBeTruthy();
  });
});
