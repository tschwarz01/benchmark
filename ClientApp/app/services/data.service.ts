import { Headers, Http } from '@angular/http';
import { Injectable } from '@angular/core';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/catch'; // <-- add rxjs operator extensions used here
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/map';

import { LoggerService } from '../services/logger.service';

import { Processor } from '../models/cpu';
import { ProcForCalc } from '../models/procForCalc';
import { Tpce } from '../models/tpce';


@Injectable()
export class DataService {
    private processorsUrl = '/api/processors/names';
    private tpceUrl = '/api/benchmark/tpce/'
    private headers = new Headers({ 'Content-Type': 'application/json' });

    constructor(
        private http: Http,
        private logger: LoggerService) { }

    getProcessors(): Observable<Processor[]> {
        this.logger.log('Getting processors as an Observable via Http ...');

        return this.http.get(this.processorsUrl)
            .map(response => response.json() as Processor[])
            .do(procs => this.logger.log(`DataService:getProcessors Got ${procs.length} Processors`));
    }

    getTpce(id: number): Observable<ProcForCalc> {
        this.logger.log('Getting tpse score as an Observable via http ...');

        return this.http.get(this.tpceUrl + id)
            .map(response => response.json() as ProcForCalc)
            .do(r => this.logger.log(`DataService:getTpce returned a score of ${r.tpse}`));
    }
}
