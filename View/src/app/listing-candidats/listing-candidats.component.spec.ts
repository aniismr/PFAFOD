import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListingCondidatsComponent } from './listing-candidats.component';

describe('ListingCondidatsComponent', () => {
  let component: ListingCondidatsComponent;
  let fixture: ComponentFixture<ListingCondidatsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListingCondidatsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListingCondidatsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
