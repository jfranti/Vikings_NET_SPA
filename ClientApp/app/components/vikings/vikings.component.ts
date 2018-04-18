import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'vikings',
    templateUrl: './vikings.component.html'
})
export class VikingComponent {
    public vikings: Viking[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Vikings/NewVikings').subscribe(result => {
            this.vikings = result.json() as Viking[];
        }, error => console.error(error));
    }
}

interface Viking {
    title: string;
    name: string;
    nation: string;
    raids: number;
}
