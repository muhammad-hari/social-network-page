import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '@environments/environment';
import { Documents } from '@app/models/document';

@Injectable({ providedIn: 'root' })
export class DocumentService {
    constructor(private http: HttpClient) { }

    getDocuments() {
        return this.http.get<Documents[]>(`${environment.apiUrl}/api/v1/SocialNetwork/Documents`);
    }


}