using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PokemonDbCreator_APIProject.Models;

namespace PokemonDbCreator_APIProject.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        PokemonDataContext PokemonDB = new PokemonDataContext();

        public IEnumerable<Pokemon> GetAll()
        {
            // TO DO : Code to get the list of all the records in database
            return PokemonDB.Pokemons;
        } //api call: GET api/Pokemon

        public Pokemon Get(int id)
        {
            // TO DO : Code to find a record in database
            return PokemonDB.Pokemons.Find(id);
        } //api call: GET api/Pokemon/id

        public Pokemon Add(Pokemon pokemon)
        {
            if (pokemon == null)
            {
                throw new ArgumentNullException("item");
            }

            // TO DO : Code to save record into database
            PokemonDB.Pokemons.Add(pokemon);
            PokemonDB.SaveChanges();
            return pokemon;
        } //api call: POST api/Pokemon + pokemon no id application/json

        public bool Update(int id, Pokemon pokemon)
        {
            if (pokemon == null)
            {
                throw new ArgumentNullException("item");
            }

            // TO DO : Code to update record into database
            var pokemons = PokemonDB.Pokemons.Single(a => a.id == pokemon.id);
            pokemons.dexNo = pokemon.dexNo;
            pokemons.name = pokemon.name;
            pokemons.type1 = pokemon.type1;
            pokemons.type2 = pokemon.type2;
            pokemons.baseHP = pokemon.baseHP;
            pokemons.baseAttack = pokemon.baseAttack;
            pokemons.baseDefense = pokemon.baseDefense;
            pokemons.baseSpecialAttack = pokemon.baseSpecialAttack;
            pokemons.baseSpecialDefense = pokemon.baseSpecialDefense;
            pokemons.baseSpeed = pokemon.baseSpeed;
            pokemons.baseTotal = pokemon.baseTotal;
            PokemonDB.SaveChanges();

            return true;
        } //api call: PUT api/Pokemon/id + pokemon with id application/json

        public bool Delete(int id)
        {
            // TO DO : Code to remove the records from database
            Pokemon pokemons = PokemonDB.Pokemons.Find(id);
            PokemonDB.Pokemons.Remove(pokemons);
            PokemonDB.SaveChanges();
            return true;
        } //api call: DELETE api/Pokemon/id
    }
}