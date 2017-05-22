import { Router } from '@angular/router';
import { AdalService } from '../../../services/adal.service';
import { Component, OnInit } from '@angular/core';
import { LoggerService } from '../../../services/logger.service';

@Component({
    templateUrl: './login.component.html'
})
export class LoginComponent implements OnInit {

    constructor(private router: Router, private adalService: AdalService, private logger: LoggerService) { }

    ngOnInit() {
        this.logger.log(`login.component.ngOnInit() has been called`);
        console.log(this.adalService.userInfo);
    }

    login() {
        this.logger.log(`login.component.login() has been called`);
        this.adalService.login();
    }

    logout() {
        this.logger.log(`login.component.logout() has been called`);
        this.adalService.logout();
    }

    public get isLoggedIn() {
        this.logger.log(`login.component.isLoggedIn() has been called`);
        var test = this.adalService.isAuthenticated;
        this.logger.log(`testing adalService.isAuthenticated - Results:  ${test}`);
        return this.adalService.isAuthenticated;
    }
}