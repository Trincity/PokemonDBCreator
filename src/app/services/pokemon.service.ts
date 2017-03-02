import { Injectable } from '@angular/core';
import { Http, Headers, Response, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs';
import 'rxjs/Rx';
import { Config } from '../app.config';
import { Pokemon } from '../models/pokemon';

@Injectable()
export class PokemonService {
  server = Config.server;

  constructor(private http : Http) { }

  sortByDexNo(pokemons: Array<Pokemon>){
    return pokemons.sort((pokemon1, pokemon2) => 
      (pokemon1['dexNo'] < pokemon2['dexNo']) ? -1 :
          (pokemon1['dexNo'] > pokemon2['dexNo']) ? 1 : 0
    );
  }

  getAllPokemon() : Observable<any>{
    return this.http.get(this.server)
      .map((res) => { return res.json(); });
  }

  getPokemon(id): Observable<Pokemon>{
    return this.http.get(this.server + id)
      .map((res) => { return res.json(); });
  }

  addPokemon(pokemon: Pokemon): Observable<any>{
    let headers = new Headers();
    headers.append('Content-Type', 'application/json');
    pokemon.baseTotal = pokemon.baseHP + pokemon.baseAttack + pokemon.baseDefense + pokemon.baseSpecialAttack + pokemon.baseSpecialDefense + pokemon.baseSpeed;
    return this.http.post(this.server, JSON.stringify(pokemon), {headers: headers});
  }

  editPokemon(pokemon: Pokemon): Observable<any>{
    let headers = new Headers({ 'Content-Type': 'application/json; charset=utf-8' });
    let options = new RequestOptions({headers: headers});
    pokemon.baseTotal = pokemon.baseHP + pokemon.baseAttack + pokemon.baseDefense + pokemon.baseSpecialAttack + pokemon.baseSpecialDefense + pokemon.baseSpeed;
    return this.http.put(this.server + '/' + pokemon.id, JSON.stringify(pokemon), options);
  }

  deletePokemon(id): Observable<any>{
    return this.http.delete(this.server + id);
  }

}
