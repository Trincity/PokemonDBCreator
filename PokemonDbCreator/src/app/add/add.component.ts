import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Validators, FormGroup, FormBuilder } from '@angular/forms';
import { PokemonService } from '../services/pokemon.service';
import { Pokemon } from '../models/pokemon';
import { Config } from '../app.config';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent implements OnInit {

  data: Pokemon = new Pokemon();
  types;
  private addForm: FormGroup;
  constructor(private _pokemonService: PokemonService, 
              fb: FormBuilder, 
              private route: ActivatedRoute, 
              private router: Router) {
    this.types = Config.types;
    this.addForm = fb.group({
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
    });
   }

  ngOnInit() {
  }

  onSubmit(){
    this._pokemonService.addPokemon(this.data)
    .subscribe(() => {
      this.router.navigate(['/list']);
    });
  }

}
