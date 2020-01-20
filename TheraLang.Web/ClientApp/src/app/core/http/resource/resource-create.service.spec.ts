import { TestBed } from "@angular/core/testing";

import { ResourceCreateService } from "./resource-create.service";

describe("ResourceCreateService", () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it("should be created", () => {
    const service: ResourceCreateService = TestBed.get(ResourceCreateService);
    expect(service).toBeTruthy();
  });
});
