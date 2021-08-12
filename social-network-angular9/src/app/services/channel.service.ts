import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '@environments/environment';
import { Channels } from '@app/models/channel';

@Injectable({ providedIn: 'root' })
export class ChannelService {
    constructor(private http: HttpClient) { }

    getChannels() {
        return this.http.get<Channels[]>(`${environment.apiUrl}/api/v1/SocialNetwork/Channels`);
    }


}