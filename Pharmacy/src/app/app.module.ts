import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NameSearchComponent } from './components/name-search/name-search.component';
import { LastNameSearchComponent } from './components/last-name-search/last-name-search.component';

@NgModule({
  declarations: [
    AppComponent,
    NameSearchComponent,
    LastNameSearchComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
