import { ConfigService } from './config.service';
import { AdalService } from './adal.service';
import { AuthenticationGuard } from './authenticated.guard';
import { DataService } from './data.service';
import { LoggerService } from './logger.service';
import { NgModule } from '@angular/core';

@NgModule({
    providers: [AdalService, ConfigService, AuthenticationGuard, DataService, LoggerService]
})
export class SharedServicesModule { }