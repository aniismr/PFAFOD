import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CategorieSelectorComponent } from './categorie-selector.component';

describe('CategorieSelectorComponent', () => {
  let component: CategorieSelectorComponent;
  let fixture: ComponentFixture<CategorieSelectorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CategorieSelectorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CategorieSelectorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
