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
        public Pokemon ActivePokemon { get; set; }

        private string _reward;

        public string Reward
        {
            get { return _reward; }
        }

        public WildEncounter(Pokemon pokemon, string reward)
        {
            this.ActivePokemon = pokemon;
            this._reward = reward;
        }

        public void BattleLost() //bool
        {

        }

        public void TryCapture() //bool
        {

        }

        public void GetReward() //string
        {

        }
    }
}
