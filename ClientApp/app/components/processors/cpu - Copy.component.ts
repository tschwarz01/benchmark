import { Component, OnInit } from '@angular/core';

//import { DataTableModule } from 'primeng/components/datatable/datatable'

import { Processor } from '../../models/cpu';
import { DataService } from '../../services/data.service';
import { LoggerService } from '../../services/logger.service';

@Component({
    selector: 'cpu',
    templateUrl: './cpu.component.html'
})
export class CpuComponent implements OnInit {
    pageTitle: string = 'Processor List';
    listFilter: string;
    errorMessage: string;
    public cpus: Processor[];
    public cpu: Processor;
    isBusy = false;

    constructor(
        private dataService: DataService,
        private logger: LoggerService) { }

    ngOnInit() {
        this.logger.log('The cpu component OnInit is fetching processor list');
        this.getProcessors();
    }

    getProcessors() {
        this.cpu = undefined;
        this.cpus = undefined;
        this.isBusy = true;

        this.dataService.getProcessors().subscribe(
            procs => {
                this.isBusy = false;
                this.cpus = procs;
                this.logger.log(`The cpu comp getProcessors method has retrieved ${this.cpus.length} processors from the web api.`);
            },
            (errorMsg: string) => {
                this.isBusy = false;
                this.logger.log('cpu component errormsg ' + errorMsg);
            }
        );
    }
}


