import {Routes, RouterModule} from '@angular/router';
import { PokemonComponent } from './pokemon/pokemon.component';
import { AddComponent } from './add/add.component';
import { EditComponent } from './edit/edit.component';

const routes : Routes = [
    {path: 'add', component : AddComponent },
    {path: 'edit/:id', component: EditComponent },
    {path: 'list', component : PokemonComponent },
    {path: '**', component : PokemonComponent }
];

export const PokemonDbRoutingModule = RouterModule.forRoot(routes)