import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { UniversalModule } from 'angular2-universal';

import { PrimeComponent } from './components/prime/prime.component';
import { ButtonModule, GrowlModule, DataTableModule, SharedModule, ContextMenuModule, MenuItem, InputTextModule } from 'primeng/primeng';

import { OAuthCallbackHandler } from './components/shared/login-callback/oauth-callback.guard';
import { OAuthCallbackComponent } from './components/shared/login-callback/oauth-callback.component';
import { OAuthHandshakeModule } from './components/shared/login-callback/oauth-callback.module';
import { AuthenticationGuard } from "./services/authenticated.guard";
import { LoginComponent } from './components/shared/login/login.component';

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/shared/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { ProcessorListComponent } from './components/processors/processor-list.component';
import { AppRoutingModule } from './shared/app.routing';

import { CpuFilterPipe } from './common/cpu-filter.pipe';
import { SumPipe } from './common/sum.pipe';

import { SharedServicesModule } from './services/shared.services.module';


@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        ProcessorListComponent,
        CpuFilterPipe,
        SumPipe,
        HomeComponent,
        PrimeComponent,
        LoginComponent
    ],
    providers: [SumPipe],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        AppRoutingModule,
        SharedServicesModule,
        OAuthHandshakeModule,
        ReactiveFormsModule,
        FormsModule,
        ButtonModule,
        DataTableModule,
        SharedModule,
        ContextMenuModule,
        InputTextModule
    ]
})
export class AppModule {
}
