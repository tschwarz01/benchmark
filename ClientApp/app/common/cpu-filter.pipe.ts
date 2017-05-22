import { PipeTransform, Pipe } from '@angular/core';
import { Processor } from '../models/cpu';

@Pipe({
    name: 'productFilter'
})
export class CpuFilterPipe implements PipeTransform {

    transform(value: Processor[], filterBy: string): Processor[] {
        filterBy = filterBy ? filterBy.toLocaleLowerCase() : null;
        return filterBy ? value.filter((product: Processor) =>
            product.productName.toLocaleLowerCase().indexOf(filterBy) !== -1) : value;
    }
}