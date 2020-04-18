using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sofia Avanccena

namespace Pokemon.BusinessLogic
{
    /* An Inherited class from Encounter for Pokemon that is owned by a trainer.
     Trainer may have more than 1 pokemon, and capturing is not allowed.
    NextPokemon : if the current active pokemon has been defeated (HP <= 0), 
    the next pokemon in the list would be moved to the current active pokemon  */
    class TrainerEncounter: Encounter
    {
        public static List<Pokemon> GetPokemonSet()
        {
            List<Pokemon> pokemonSet = new List<Pokemon>();
            pokemonSet.Add(new Pokemon
            {

            });
            pokemonSet.Add(new Pokemon
            {

            });
            pokemonSet.Add(new Pokemon
            {

            });
            return pokemonSet;
        }
    }
}

//testing 

