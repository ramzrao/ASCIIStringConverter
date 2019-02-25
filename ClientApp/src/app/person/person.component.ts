import { Component, OnInit } from '@angular/core';
import { PersonService } from '../shared/Person.service';
import { Person } from '../core/models/person.model';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  person:Person = {
    fullName:'',
    zeroCntInBinASCIIName:undefined
  };
  isLoading:boolean = false;
  constructor(private personService: PersonService) { }

  ngOnInit() {
    
  }

  submit(){
    this.isLoading = true;
    this.person.zeroCntInBinASCIIName = undefined;
    this.personService.save(this.person).subscribe(
      (personData: Person) => {
        this.person.zeroCntInBinASCIIName = personData.zeroCntInBinASCIIName;
        this.isLoading = false;
      },(err)=>{this.isLoading = false;}
    );
  }

}
