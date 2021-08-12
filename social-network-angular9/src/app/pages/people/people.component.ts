import { Component, OnInit } from '@angular/core';
import { People } from '@app/models/people';
import { PeopleService } from '@app/services/people.service';
import { first } from 'rxjs/operators';

@Component({
  selector: 'app-people',
  templateUrl: './people.component.html',
  styleUrls: ['./people.component.css']
})
export class PeopleComponent implements OnInit {
  loading = false;
  people: People[];

  constructor(private peopleService: PeopleService) { }

  ngOnInit(): void {
    this.loading = true;
    this.peopleService.getPeople().pipe(first()).subscribe(people => {
        this.loading = false;
        this.people = people;
        console.log(people);
    });
  }
}
