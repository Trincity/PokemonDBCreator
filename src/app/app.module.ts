import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { AddComponent } from './add/add.component';
import { PokemonComponent } from './pokemon/pokemon.component';
import { EditComponent } from './edit/edit.component';

import { PokemonDbRoutingModule } from './app-routing.module';
import { PokemonService } from './services/pokemon.service';
import { AscendingOrderPipe } from './pipes/ascending-order.pipe';


@NgModule({
  declarations: [
    AppComponent,
    AddComponent,
    PokemonComponent,
    EditComponent,
    AscendingOrderPipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpModule,
    PokemonDbRoutingModule
  ],
  providers: [PokemonService],
  bootstrap: [AppComponent]
})
export class AppModule { }
