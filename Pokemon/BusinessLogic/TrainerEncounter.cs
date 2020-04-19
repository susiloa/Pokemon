using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Automation;

//Sofia Avanccena

namespace Pokemon.BusinessLogic
{
    /* An Inherited class from Encounter for Pokemon that is owned by a trainer.
     Trainer may have more than 1 pokemon, and capturing is not allowed.
    NextPokemon : if the current active pokemon has been defeated (HP <= 0), 
    the next pokemon in the list would be moved to the current active pokemon  */
    class TrainerEncounter: Encounter
    {
        //Properties
        public Pokemon ActivePokemon { get; set; }
        public List<Pokemon> _reservePokemon { get; set; }
        private string _reward;

        public string Reward
        {
            get { return _reward}
        }

        //Constructor
        public TrainerEncounter(Pokemon pokemon, Encounter reward)
        {

        }

        //Methods
        public override bool BattleLost()
        {
            if (ActivePokemon.Health == 0 && _reservePokemon.Count == 0) return true;
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
            return "You won a badge and 100 EXP! Congratulations, you are one step closer to becoming a pokemon master!";
        }
    }
}

//testing 

