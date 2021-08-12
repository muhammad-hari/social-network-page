import { Component } from '@angular/core';
import { Router } from '@angular/router';

import { AuthenticationService } from './services';
import { User } from './models';
import { MenuItem } from './models/menu';

@Component({ selector: 'app', templateUrl: 'app.component.html', styleUrls: ['app.component.css'] })
export class AppComponent {
    currentUser: User;

    parentMenuItems: MenuItem[] = [];

    childMenuItems: MenuItem[] = [
        {
          label: 'Videos',
          icon: 'movie'
        },
        {
          label: 'People',
          icon: 'supervised_user_circle'
        },
        {
          label: 'Documents',
          icon: 'file_copy'
        },
        {
          label: 'Events',
          icon: 'notes'
        },
        {
          label: 'Communities',
          icon: 'group'
        },
        {
          label: 'Favorite',
          icon: 'favorite'
        },
        {
            label: 'Channels',
            icon: 'rss_feed'
          },
      ];

    constructor(
        private router: Router,
        private authenticationService: AuthenticationService
    ) {
        this.authenticationService.currentUser.subscribe(x => this.currentUser = x);
        if(this.currentUser != null){
          this.parentMenuItems = [{
            label: this.currentUser.username,
            icon: 'account_circle'
          }];
        }
    }

    ngOnInit(){
      if(this.currentUser != null){
        this.parentMenuItems = [{
          label: this.currentUser.username,
          icon: 'account_circle'
        }];
      }
    }

    logout() {
        this.authenticationService.logout();
        this.router.navigate(['/login']);
    }
}