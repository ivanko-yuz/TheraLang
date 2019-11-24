import { TestBed } from "@angular/core/testing";

import { TypeProjectService } from "./type-project.service";

describe("TypeProjectService", () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it("should be created", () => {
    const service: TypeProjectService = TestBed.get(TypeProjectService);
    expect(service).toBeTruthy();
  });
});
