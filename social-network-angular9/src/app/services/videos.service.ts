import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '@environments/environment';
import { Videos } from '@app/models/videos';

@Injectable({ providedIn: 'root' })
export class VideosService {
    constructor(private http: HttpClient) { }

    getVideos() {
        return this.http.get<Videos[]>(`${environment.apiUrl}/api/v1/SocialNetwork/Videos`);
    }


}