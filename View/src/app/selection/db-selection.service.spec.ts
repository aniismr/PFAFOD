import { TestBed } from '@angular/core/testing';

import { DbSelectionService } from './db-selection.service';

describe('DbSelectionService', () => {
  let service: DbSelectionService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DbSelectionService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
