import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LastNameSearchComponent } from './last-name-search.component';

describe('LastNameSearchComponent', () => {
  let component: LastNameSearchComponent;
  let fixture: ComponentFixture<LastNameSearchComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LastNameSearchComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LastNameSearchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
