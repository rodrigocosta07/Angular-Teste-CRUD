import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PerguntasCadastroComponent } from './perguntas-cadastro.component';

describe('PerguntasCadastroComponent', () => {
  let component: PerguntasCadastroComponent;
  let fixture: ComponentFixture<PerguntasCadastroComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PerguntasCadastroComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PerguntasCadastroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
