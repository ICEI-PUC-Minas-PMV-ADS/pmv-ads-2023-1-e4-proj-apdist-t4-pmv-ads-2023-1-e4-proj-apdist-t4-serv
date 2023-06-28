import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalharOrcamentosComponent } from './detalhar-orcamentos.component';

describe('DetalharOrcamentosComponent', () => {
  let component: DetalharOrcamentosComponent;
  let fixture: ComponentFixture<DetalharOrcamentosComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DetalharOrcamentosComponent]
    });
    fixture = TestBed.createComponent(DetalharOrcamentosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
