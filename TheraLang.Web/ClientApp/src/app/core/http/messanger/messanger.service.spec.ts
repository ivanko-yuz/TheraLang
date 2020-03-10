import { TestBed } from '@angular/core/testing';

import { MessangerService } from './messanger.service';

describe('MessangerService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: MessangerService = TestBed.get(MessangerService);
    expect(service).toBeTruthy();
  });
});
