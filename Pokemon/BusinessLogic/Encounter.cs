using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sofia Avancena

namespace Pokemon.BusinessLogic
{
    public class Encounter
    {
        public Pokemon ActivePokemon { get; set; }
		private string _reward;

		public string Reward
		{
			get { return _reward; }
		}

        public void BattleLost() //bool
        {

        }

        public void GetReward() //string
        {

        }

	}
}
