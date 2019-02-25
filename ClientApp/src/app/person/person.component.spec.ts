import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonComponent } from './person.component';
import { SharedModule } from '../Shared/shared.module';
import { PersonService } from '../Shared/Person.service';
import { of, Observable } from 'rxjs';
import { HttpClientModule } from '@angular/common/http';
import { ApiService } from '../Shared/api.service';
import { DebugElement } from '@angular/core';
import { Person } from '../core/models/person.model';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

describe('PersonComponent', () => {
	let comp: PersonComponent;
	let fixture: ComponentFixture<PersonComponent>;
	let componentPersonService: PersonService; // the actually injected service
	let personService: PersonService; // the TestBed injected service
	let de: DebugElement;  // the DebugElement with the welcome message
	let el: HTMLElement; // the DOM element with the welcome message

	let personServiceStub: {
		save(person):Observable<Person>
	};

	beforeEach(async () => {
		// stub personServiceStub for test purposes
		class personServiceStub {
			save(person):Observable<Person>{
        return of({'fullName':'Ann Other','zeroCntInBinASCIIName':2});
      }
		};

		await TestBed.configureTestingModule({
        declarations: [ PersonComponent ],
        imports:[CommonModule,FormsModule],
				providers:[
					{ provide: PersonService, useClass: personServiceStub }
				]
			})
			.compileComponents()
		;

		fixture = TestBed.createComponent(PersonComponent);
		comp    = fixture.componentInstance;

		
		personService = fixture.debugElement.injector.get(PersonService);
		componentPersonService = personService;
		personService = TestBed.get(PersonService);

		// //  get the "welcome" element by CSS selector (e.g., by class name)
		// de = fixture.debugElement.query(By.css('.welcome'));
		// el = de.nativeElement;
	});

	it('should create', () => {
    fixture.detectChanges();
    expect(comp).toBeTruthy();
  });

});