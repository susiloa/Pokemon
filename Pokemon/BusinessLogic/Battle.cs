using System;
using System.Collections.Generic;

namespace Pokemon
{
    public class Battle
    {

        public Pokemon userPokemon { get;}
        public Encounter encounter { get;}
        public List<String> BattleMessage { get; set; }
        public bool GameEnd { get; private set; }

        private bool isPlayerTurn;
        private Pokemon enemyPokemon;
        private bool userVictory;
        private int moveCount;


        public Battle(Pokemon userPokemon, Encounter encounter)
        {
            this.userPokemon = userPokemon;
            this.encounter = encounter;
            BattleMessage = new List<string>();
        }

        public void BattleStart()
        {
            enemyPokemon = encounter.ActivePokemon;
            resolveTurn();
        }

        public void resolveTurn()
        {
            moveCount = 0;
            if (userPokemon.Speed < enemyPokemon.Speed)
            {
                isPlayerTurn = false;
            }

            //BattleMessage
            Console.WriteLine((isPlayerTurn) ? "Player Goes First" : "Enemy Goes First");
            BattleMessage.Add((isPlayerTurn) ? "Player Goes First" : "Enemy Goes First");
            startOfTurn();
        }

        public void startOfTurn()
        {
            if (!isPlayerTurn)
            {
                AttackPhase(enemyPokemon.SelectRandomMove());
            }
        }

        public void AttackPhase(Move selectedMove)
        {
            double damage;
            if (isPlayerTurn)
            {
                damage = userPokemon.ExecuteAttack(enemyPokemon, selectedMove);
                BattleMessage.Add(userPokemon + " attacked with " + selectedMove + "\n");
                BattleMessage.Add(enemyPokemon + " received " + damage + " damage\n");
            }
            else
            {
                damage = enemyPokemon.ExecuteAttack(userPokemon, selectedMove);
                BattleMessage.Add(enemyPokemon + " attacked with " + selectedMove + "\n");
                BattleMessage.Add(userPokemon + " received " + damage + " damage\n");
            }
            moveCount++;
            EndOfTurn();
        }

        public void EndOfTurn()
        {

            if (userPokemon.IsDead)
            {
                userVictory = false;
                EndBattle();
            }
            else if (encounter.BattleLost())
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
            GameEnd = true;

            //if (userVictory)
            //{
            //    Console.WriteLine(encounter.GetReward());
            //}
            //else
            //{
            //    Console.WriteLine("I'm sorry, you have lost the game.");
            //}
        }
    }
}
