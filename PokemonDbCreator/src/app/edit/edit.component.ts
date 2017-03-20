import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Validators, FormGroup, FormBuilder } from '@angular/forms';
import { PokemonService } from '../services/pokemon.service';
import { Pokemon } from '../models/pokemon';
import { Config } from '../app.config';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {

  pokemon: Pokemon = new Pokemon();
  private editForm: FormGroup;
  types = Config.types;
  constructor(private _pokemonService: PokemonService,
              fb: FormBuilder, 
              private route: ActivatedRoute, 
              private router: Router) {
    this.editForm = fb.group({
      'name': ['', [Validators.required, Validators.minLength(3)]],
      'dexNo': ['', [Validators.required]],
      'type1': ['', [Validators.required]],
      'type2': [''],
      'hp': ['', [Validators.required]],
      'attack': ['', [Validators.required]],
      'defense': ['', [Validators.required]],
      'spAttack': ['', [Validators.required]],
      'spDefense': ['', [Validators.required]],
      'speed': ['', [Validators.required]]
    })
  }

  ngOnInit() {
    this.route.params.subscribe(params => {
      let id = +params['id'];
      this._pokemonService.getPokemon(id).first()
      .toPromise()
      .then((pokemon) => { this.pokemon = pokemon; });
    });
  }

  onSubmit(){
    this._pokemonService.editPokemon(this.pokemon)
    .subscribe(() => {
      this.router.navigate(['/list']);
    });
  }

}
