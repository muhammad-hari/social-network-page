import { Component, OnInit } from '@angular/core';
import { Activity } from '@app/models/activity';
import { ActivitiesService } from '@app/services/activities.service';
import { first } from 'rxjs/operators';

@Component({
  selector: 'app-activities',
  templateUrl: './activities.component.html',
  styleUrls: ['./activities.component.css']
})
export class ActivitiesComponent implements OnInit {
  loading = false;
  activities: Activity[];
  
  constructor(private activitiesService: ActivitiesService) { }

  ngOnInit() {
    this.loading = true;
    this.activitiesService.getActivities().pipe(first()).subscribe(activities => {
        this.loading = false;
        this.activities = activities;
        console.log(activities);
    });
  }

}
