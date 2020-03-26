import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailCandidatureComponent } from './detail-candidature.component';

describe('DetailCandidatureComponent', () => {
  let component: DetailCandidatureComponent;
  let fixture: ComponentFixture<DetailCandidatureComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DetailCandidatureComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailCandidatureComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
