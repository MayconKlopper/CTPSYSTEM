import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgxAdminLteModule } from 'ngx-admin-lte';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    NgxAdminLteModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
