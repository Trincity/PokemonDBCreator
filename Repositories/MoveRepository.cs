using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PokemonDbCreator_APIProject.Models;

namespace PokemonDbCreator_APIProject.Repositories
{
    public class MoveRepository : IMoveRepository
    {
        PokemonDataContext PokemonDB = new PokemonDataContext();

        public IEnumerable<Move> GetAll()
        {
            return PokemonDB.Moves;
        }

        public Move Get(int id)
        {
            return PokemonDB.Moves.Find(id);
        }

        public Move Add(Move move)
        {
            if(move == null)
            {
                throw new ArgumentNullException("move");
            }

            PokemonDB.Moves.Add(move);
            PokemonDB.SaveChangesAsync();
            return move;
        }

        public bool Update(int id, Move move)
        {
            if(move == null)
            {
                throw new ArgumentNullException("move");
            }

            var moves = PokemonDB.Moves.Single(a => a.id == move.id);
            moves.moveId = move.moveId;
            moves.name = move.name;
            moves.power = move.power;
            moves.pp = move.pp;
            moves.type = move.type;
            moves.description = moves.description;
            moves.accuracy = move.accuracy;
            moves.gen = move.gen;
            moves.category = move.category;
            moves.contest = move.contest;
            PokemonDB.SaveChangesAsync();
            return true;
        }

        public bool Delete(int id)
        {
            Move move = PokemonDB.Moves.Find(id);
            PokemonDB.Moves.Remove(move);
            PokemonDB.SaveChangesAsync();
            return true;
        }
    }
}