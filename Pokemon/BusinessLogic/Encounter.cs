using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sofia Avancena
/* An abstract class that keeps track of the status of the type of battle (wild or traniner) */

namespace Pokemon
{
    public abstract class Encounter
    {
        public String BattleType { get; set; }
        public Pokemon ActivePokemon { get; set; }
        protected string _reward;

        public string Reward
        {
            get { return _reward; }
        }

        //Check if the battle had lost, and what would happen if so
        public virtual bool BattleLost()
        {
            return false;
        }

        // Send a string message of the reward that is received, gets overriden
        public virtual string GetReward()
        {
            return "Congratulations you won 100 EXP!";
        }

    }
}