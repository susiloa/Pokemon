using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.BusinessLogic

{
    public class Battle
    {

        private Pokemon userPokemon { get; set; }
        private Encounter encounter { get; set; }

        private boolean isPlayerTurn;
        private Pokemon enemyPokemon;
        private boolean userVictory;
        private int moveCount;


        public Battle(Pokemon userPokemon, Encounter encounter)
        {
            this.userPokemon = userPokemon;
            this.encounter = encounter;
        }

        public void BattleSetup()
        {
            enemyPokemon = encounter.ActivePokemon;
        }

        public void resolveTurn()
        {
            moveCount = 0;
            if (userPokemon.Speed < enemyPokemon.Speed)
            {
                isPlayerTurn = false;
            }
        }

        public void startOfTurn()
        {
            userPokemon.resolveStatus();
            enemyPokemon.resolveStatus();

            if (!isPlayerTurn)
            {
                AttackPhase(enemyPokemon.selectRandomMove());
            }
            else
            {
                // display user pokemon move
            }
        }

        public void AttackPhase(Move selectedMove)
        {
            if (isPlayerTurn)
            {
                userPokemon.Attack(enemyPokemon, selectedMove);
            }
            else
            {
                enemyPokemon.Attack(userPokemon, selectedMove);
            }
            moveCount++;
            EndOfTurn()
        }

        public void EndOfTurn()
        {
            if (userPokemon.isDead)
            {
                userVictory = false;
                EndBattle();
            }
            else if (enemyPokemon.isDead)
            {
                userVictory = true;
                EndBattle();
            }
            else
            {
                if (moveCount == 2)
                {
                    resolveTurn();
                }
                else
                {
                    isPlayerTurn = !isPlayerTurn;
                    startOfTurn();
                }
            }
        }

        public void EndBattle()
        {
            if (userVictory)
            {
                Message.show(encounter.ShowReward());
            }
            else
            {
                Message.show("I'm sorry, you have lost the game.");
            }
        }
    }
}

