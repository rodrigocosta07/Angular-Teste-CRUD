import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PerguntasListaComponent } from './perguntas-lista.component';

describe('PerguntasListaComponent', () => {
  let component: PerguntasListaComponent;
  let fixture: ComponentFixture<PerguntasListaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PerguntasListaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PerguntasListaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
