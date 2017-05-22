﻿/// <reference path="../../../node_modules/@types/adal/index.d.ts" />
import { ConfigService } from './config.service';
import { Injectable } from '@angular/core';
//declare var adal: any;
import 'expose-loader?AuthenticationContext!../../../node_modules/adal-angular/lib/adal.js';
let createAuthContextFn: adal.AuthenticationContextStatic = AuthenticationContext;

@Injectable()
export class AdalService {

    private context: adal.AuthenticationContext;
    constructor(private configService: ConfigService) {
        this.context = new createAuthContextFn(configService.getAdalConfig);
    }

    login() {
        this.context.login();
    }

    logout() {
        this.context.logOut();
    }

    handleCallback() {
        this.context.handleWindowCallback();
    }

    public get userInfo() {
        return this.context.getCachedUser();
    }

    public get accessToken() {
        return this.context.getCachedToken(this.configService.getAdalConfig.clientId);
    }

    public get isAuthenticated() {
        console.log(`adal.service.isAuthenticated() is firing`);
        return this.userInfo && this.accessToken;
    }
}