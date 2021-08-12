import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '@environments/environment';
import { Activity } from '@app/models/activity';

@Injectable({ providedIn: 'root' })
export class ActivitiesService {
    constructor(private http: HttpClient) { }

    getActivities() {
        return this.http.get<Activity[]>(`${environment.apiUrl}/api/v1/SocialNetwork/Activities`);
    }


}