import { Component, OnInit } from '@angular/core';
import {    ButtonModule,   GrowlModule,   Message} from 'primeng/primeng';

import { DataService } from '../../services/data.service';
import { LoggerService } from '../../services/logger.service';

import { Processor } from '../../models/cpu';

@Component({
    selector: 'prime',
    templateUrl: './prime.component.html'
})
export class PrimeComponent implements OnInit {
    pageTitle: string = 'Select Processors';
    errorMessage: string;
    listFilter: string;
    msgs: Message[] = [];
    cpus: Processor[];

    constructor(private dataService: DataService,
                private logger: LoggerService) {
        
    }

    ngOnInit(): void {
        this.logger.log('The prime component OnInit is fetching processor list');
        this.getProcessors();
    }

    getProcessors() {
        this.dataService.getProcessors()
            .subscribe(procs => this.cpus = procs,
                       error => this.errorMessage = <any>error);
    }

}