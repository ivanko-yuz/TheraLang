import { TestBed } from '@angular/core/testing';

import { ProjectRequestService } from './project-request.service';

describe('ProjectRequestService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ProjectRequestService = TestBed.get(ProjectRequestService);
    expect(service).toBeTruthy();
  });
});
