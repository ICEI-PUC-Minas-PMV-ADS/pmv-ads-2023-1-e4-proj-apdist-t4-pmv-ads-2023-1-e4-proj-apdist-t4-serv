import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CriarPedidosComponent } from './criar-pedidos.component';

describe('CriarPedidosComponent', () => {
  let component: CriarPedidosComponent;
  let fixture: ComponentFixture<CriarPedidosComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CriarPedidosComponent]
    });
    fixture = TestBed.createComponent(CriarPedidosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
