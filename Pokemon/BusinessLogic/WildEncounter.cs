using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sofia Avancena

namespace Pokemon
{
    /* An inherited class from Encounter for Pokémon that is found in the wild.
     It will guarantee that only 1 Pokémon is involved
     There is a possibility to capture the Pokémon. */
    public class WildEncounter : Encounter
    {
        private bool _isCaptured = false;

        //Constructor
        public WildEncounter(Pokemon pokemon, string reward)
        {
            this.ActivePokemon = pokemon;
            this._reward = reward;
        }

        //Methods
        public override bool BattleLost()
        {
            if (ActivePokemon.Health <= 0 || _isCaptured) return true;
            else return false;
        }

        public bool TryCapture()
        {
            if (ActivePokemon.Health > 0)
            {
                Random randomNumber = new Random();
                int Attempt = randomNumber.Next(7);

                if (Attempt % 2 != 0)
                {
                    _isCaptured = true;
                    return true;
                }
                else return false;
            }

            else return false;
        }


        public override string GetReward()
        {
            String message = "Congratulations you won " + _reward;
            message += (_isCaptured) ? " and captured " + ActivePokemon + "!" : "!";
            return "Congratulations you won 100 EXP!";
        }
    }
}