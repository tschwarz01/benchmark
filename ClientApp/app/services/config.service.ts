import { Injectable } from '@angular/core';

@Injectable()
export class ConfigService {
    constructor() {
    }
    public get getAdalConfig(): any {
        return {
            tenant: '8d35c066-f58b-4a1e-ad07-493408decd1e',
            clientId: '63e3dc84-eb1b-4f8c-9fa3-1427e1e18679',
            redirectUri: window.location.origin + '/',
            postLogoutRedirectUri: window.location.origin + '/'
        };
    }
}