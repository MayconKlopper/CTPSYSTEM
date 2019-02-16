import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
    collapseOne = true;
    collapseTwo = true;
    collapseThree = true;
    collapseFour = true;

    constructor() { }

    ngOnInit(): void { }
}
