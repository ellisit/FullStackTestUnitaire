import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WarningDialogComponent } from './warning-dialog.component';
import { MaterialModule } from '../material/material.module';
import { NO_ERRORS_SCHEMA } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';

describe('WarningDialogComponent', () => {
  let component: WarningDialogComponent;
  let fixture: ComponentFixture<WarningDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WarningDialogComponent ],
      schemas: [ NO_ERRORS_SCHEMA ],
       providers: [ MatDialogRef ],
       imports: [ MaterialModule ],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WarningDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
