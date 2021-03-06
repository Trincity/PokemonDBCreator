import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { PokemonService } from '../services/pokemon.service';
import { TypeService } from '../services/type.service';
import { AscendingOrderPipe } from '../pipes/ascending-order.pipe';

@Component({
  selector: 'app-pokemon',
  templateUrl: './pokemon.component.html',
  styleUrls: ['./pokemon.component.css']
})
export class PokemonComponent implements OnInit {
  pokemons = [];
  addTag = false;

  constructor(private _pokemonService: PokemonService, private _typeService: TypeService, private _router: Router) { }

  ngOnInit() {
    this._pokemonService.getAllPokemon()
      .subscribe((pokemons) => {
        this.pokemons = this._pokemonService.sortByDexNo(pokemons);
      });
      if(this._router.url == '/add'){
        this.addTag = true;
      }
    this._typeService.types = this._typeService.getAllTypes();
  }

  deletePokemon(id){
    this._pokemonService.deletePokemon(id)
    .subscribe(() => {
      this._router.navigate(['/list']);
    });
  }
}
