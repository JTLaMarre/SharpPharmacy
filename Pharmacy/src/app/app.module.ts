import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
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
    AppRoutingModule,
    HttpClientModule,
    FormsModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
