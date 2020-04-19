using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sofia Avancena

namespace Pokemon.BusinessLogic
{
    public class WildEncounter: Encounter
    {
        public int Attempt;

        //Properties
        public Pokemon ActivePokemon { get; set; }
        private string _reward;
        public string Reward
        {
            get { return _reward; }
        }

        //Constructor
        public WildEncounter(Pokemon pokemon, string reward)
        {
            this.ActivePokemon = pokemon;
            this._reward = reward;
        }

        //Methods
        public override bool BattleLost()
        {
            if (ActivePokemon.Health == 0) return true;
            else return false;
        }

        public bool TryCapture()
        {
            if (Pokemon.Health == 0)
            {
                Random randomNumber = new Random();
                Attempt = randomNumber.Next(1, 7);

                if (Attempt % 2 != 0) return true;
                else return false;
            }

            else return false;
        }


        public override string GetReward() //string
        {
            return "Congratulations you won 100 EXP!";
        }
    }
}

//Commit again
