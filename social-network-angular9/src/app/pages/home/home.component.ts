import { Component, Input } from '@angular/core';
import { first } from 'rxjs/operators';

import { User } from '@app/models';
import { UserService, AuthenticationService } from '@app/services';

@Component({ templateUrl: 'home.component.html',  styleUrls: ['home.component.css'] })
export class HomeComponent {

    @Input('joke') data: string;
    loading = false;
    users: User[];

    constructor(private userService: UserService) { 
        window.location.reload;
    }

    ngOnInit() {
        this.loading = true;
        this.userService.getAll().pipe(first()).subscribe(users => {
            this.loading = false;
            this.users = users;
        });
    }

}