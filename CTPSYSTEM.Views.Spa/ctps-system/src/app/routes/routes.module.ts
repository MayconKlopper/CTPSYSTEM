import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';


import { CanActivateGuard, LayoutAuthComponent } from 'ngx-admin-lte';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
    // logged routes
    {
        canActivate: [CanActivateGuard],
        children: [
            {
                canActivate: [CanActivateGuard],
                component: HomeComponent,
                path: 'home'
            }
        ],
        component: LayoutAuthComponent,
        path: '',
    }
];

@NgModule({
    declarations: [],
    imports: [CommonModule,
        RouterModule.forRoot(routes)],
    exports: [],
    providers: [],
})
export class RoutesModule { }