import { TestBed } from '@angular/core/testing';

import { TipoDificuldadeService } from './tipo-dificuldade.service';

describe('TipoDificuldadeService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: TipoDificuldadeService = TestBed.get(TipoDificuldadeService);
    expect(service).toBeTruthy();
  });
});
