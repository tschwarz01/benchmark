
import { Component, OnInit } from '@angular/core';

import { Processor } from '../../models/cpu';

import { DataService } from '../../services/data.service';
import { LoggerService } from '../../services/logger.service';

@Component({
    selector: 'calculator',
    template: 'Hello my name is {{name}}.'
})
export class CalculatorComponent implements OnInit {
    constructor(
        private dataService: DataService,
        private logger: LoggerService) { }

    ngOnInit() {
        this.logger.log('The calculator component OnInit is fetching processor list');
        //this.getProcessors();
    }
}
