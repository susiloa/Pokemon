using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sofia Avancena

namespace Pokemon
{
    public class WildEncounter: Encounter
    {
        private bool captured = false;

        //Constructor
        public WildEncounter(Pokemon pokemon, string reward)
        {
            this.ActivePokemon = pokemon;
            this._reward = reward;
        }

        //Methods
        public override bool BattleLost()
        {
            if (ActivePokemon.Health <= 0 || captured) return true;
            else return false;
        }

        public bool TryCapture()
        {
            if (ActivePokemon.Health > 0)
            {
                Random randomNumber = new Random();
                int Attempt = randomNumber.Next(7);

                if (Attempt % 2 != 0) {
                    captured = true;
                    return true;
                }
                else return false;
            }

            else return false;
        }


        public override string GetReward() //string
        {
            String message = "Congratulations you won " + _reward;
            message += (captured) ? " and captured " + ActivePokemon + "!" : "!";
            return "Congratulations you won 100 EXP!";
        }
    }
}

//Commit again
