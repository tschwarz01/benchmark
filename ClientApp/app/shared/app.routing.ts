import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { HomeComponent } from '../components/home/home.component';
import { ProcessorListComponent } from '../components/processors/processor-list.component';

import { LoginComponent } from '../components/shared/login/login.component';
import { OAuthCallbackHandler } from '../components/shared/login-callback/oauth-callback.guard';
import { OAuthCallbackComponent } from '../components/shared/login-callback/oauth-callback.component';
import { AuthenticationGuard } from "../services/authenticated.guard";

@NgModule({
    imports: [
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent }, 
            //{ path: 'home', component: HomeComponent, canActivate: [AuthenticationGuard] }, 
            { path: 'login', component: LoginComponent },
            { path: 'processors', component: ProcessorListComponent },
            //{ path: 'processors', component: ProcessorListComponent, canActivate: [AuthenticationGuard] },
            { path: 'id_token', component: OAuthCallbackComponent, canActivate: [OAuthCallbackHandler] }, 
            { path: '**', redirectTo: 'home' }
        ])
    ],
    exports: [
        RouterModule
    ]
})

export class AppRoutingModule {}