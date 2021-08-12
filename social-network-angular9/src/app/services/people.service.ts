import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '@environments/environment';
import { People } from '@app/models/people';

@Injectable({ providedIn: 'root' })
export class PeopleService {
    constructor(private http: HttpClient) { }

    getPeople() {
        return this.http.get<People[]>(`${environment.apiUrl}/api/v1/SocialNetwork/People`);
    }


}