import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public cpus: ProcessorNames[];

    constructor(http: Http) {
        http.get('/api/processors/names').subscribe(result => {
            this.cpus = result.json() as ProcessorNames[];
        });
    }
}

interface ProcessorNames {
    id: number;
    productName: string;
    productNameDetails: string;
    launchDate: Date;
}
