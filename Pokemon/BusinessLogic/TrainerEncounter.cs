using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sofia Avanccena
/* An Inherited class from Encounter.cs for Pokémon that is owned by a trainer.
 Trainer may have more than 1 Pokémon, and capturing is not allowed. */

namespace Pokemon
{
    class TrainerEncounter : Encounter
    {
        //Properties
        public List<Pokemon> _reservePokemon { get; set; }

        //Constructor
        public TrainerEncounter(List<Pokemon> pokemons, String reward)
        {
            ActivePokemon = pokemons[0];
            pokemons.RemoveAt(0);
            this._reservePokemon = pokemons;
            this._reward = reward;
        }

        //Methods
        public override bool BattleLost()
        {
            if (ActivePokemon.Health <= 0 && _reservePokemon.Count <= 0) return true;
            else if (_reservePokemon.Count >= 1)
            {
                NextPokemon();
                return false;
            }
            else return false;
        }

        public void NextPokemon()
        {
            ActivePokemon = _reservePokemon[0];
            _reservePokemon.RemoveAt(0);
        }

        public override string GetReward()
        {
            return "You won a badge, " + _reward + "! Congratulations, you are one step closer to becoming a pokemon master!";
        }
    }
}

