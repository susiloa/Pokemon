using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sofia Avancena

namespace Pokemon.BusinessLogic
{
    /* An abstract class that keeps track of the status of the pokemon (wild or traniner) */
    public abstract class Encounter
    {
        public Pokemon ActivePokemon { get; set; }
        private string _reward;

        public string Reward
        {
            get { return _reward; }
        }

        //	Check if the battle had lost, and what would happen if so
        public virtual bool BattleLost()
        {
            return false;
        }

        // Send a string message of the reward that is received
        public virtual string GetReward()
        {
            return "Congratulations you won 100 EXP!";
        }

    }
}