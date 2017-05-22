import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { GrowlModule, MenuModule, MenuItem, Message, InputText } from 'primeng/primeng'

import { Processor } from '../../models/cpu';
import { ProcForCalc } from '../../models/procForCalc';
import { Tpce } from '../../models/tpce';

import { DataService } from '../../services/data.service';
import { LoggerService } from '../../services/logger.service';
import { SumPipe } from '../../common/sum.pipe';

@Component({
    selector: 'processors',
    templateUrl: './processor-list.component.html'
})
export class ProcessorListComponent implements OnInit {
    pageTitle: string = 'Processor List';
    listFilter: string;
    errorMessage: string;
    proc: Processor;
    procForCalc: ProcForCalc;
    procsForCalc: ProcForCalc[];
    public cpus: Processor[];
    selectedCpu: Processor;
    selectedCpus: Processor[];
    tpseSum: number;
    isBusy = false;

    constructor(private dataService: DataService, private logger: LoggerService, private sumPipe: SumPipe) { 
        this.procsForCalc = [];
    }

    ngOnInit() {
        this.getProcessors();
    }

    getProcessors() {
        this.dataService.getProcessors()
            .subscribe(procs => this.cpus = procs,
                       error => this.errorMessage = <any>error);
    }

    selectCpu(cpu: Processor) {
        this.procForCalc = null;
        this.dataService.getTpce(cpu.id)
            .subscribe(
                res => {
                    this.procForCalc = new ProcForCalc(res.id, res.productNameFull, 1, res.tpse, res.tpseCore);
                    this.procsForCalc.push(this.procForCalc);
                    this.tpseSum = this.sumPipe.transform(this.procsForCalc, 'totalTpse');
                },
                (errorMsg: string) => {
                    this.logger.log('cpu component tpse method errormsg ' + errorMsg);
                }
        );  
    }

    removeCpu(cpu: ProcForCalc)
    {
        let index = this.procsForCalc.indexOf(cpu)
        this.procsForCalc = this.procsForCalc.filter((val, i) => i != index);
        cpu = null;

        this.tpseSum = this.sumPipe.transform(this.procsForCalc, 'totalTpse');
    }

    doSomething(cpu: any) {
        this.tpseSum = this.sumPipe.transform(this.procsForCalc, 'totalTpse');
    }

    //getAgeSum(): Observable<number> {
    //    return this.studentsObservable
    //        .map(arr => arr.reduce((a, b) => a + b.age, 0));
    //}
    //http://stackoverflow.com/questions/37109928/angular2-sum-the-values-of-a-property-in-the-object-sent-from-an-observerable
}


