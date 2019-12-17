import { PipeTransform, Pipe } from '@angular/core';
import { Resource } from '../general-resources/resource-models/resource';

@Pipe({
    name: 'resourcesFilter',
    pure: false
})

export class ResourcesFilterPipe implements PipeTransform {
    private counter = 0;
    transform(resources: Resource[], searchTerm: string): Resource[] {
        this.counter++;
        console.log('filter pipe exec.. ' + this.counter);
        if (!resources || !searchTerm) {
            return resources;
        }

        return resources.filter(resources =>
            resources.name.toLowerCase().indexOf(searchTerm.toLowerCase()) !== -1);
    }
}