import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TestTechniqueComponent } from './test-technique.component';

describe('TestTechniqueComponent', () => {
  let component: TestTechniqueComponent;
  let fixture: ComponentFixture<TestTechniqueComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TestTechniqueComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TestTechniqueComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
