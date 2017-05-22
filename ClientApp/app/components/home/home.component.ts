import { AdalService } from '../../services/adal.service';
import { Component } from '@angular/core';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    constructor(private adalService: AdalService) {
        
    }
}
