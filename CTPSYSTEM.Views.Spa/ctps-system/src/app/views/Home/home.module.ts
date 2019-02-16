import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeComponent } from './Home.component';

import { CollapseModule } from 'ngx-bootstrap/collapse';

@NgModule({
    declarations: [ HomeComponent ],
    imports: [ CommonModule, CollapseModule ],
    exports: [ HomeComponent ],
    providers: [],
})
export class HomeModule {}
