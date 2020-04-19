using System;

namespace Pokemon
{
    public class Battle
    {

        private Pokemon userPokemon { get;}
        private Encounter encounter { get;}
        public String BattleMessage { get; set; }

        private bool isPlayerTurn;
        private Pokemon enemyPokemon;
        private bool userVictory;
        private int moveCount;


        public Battle(Pokemon userPokemon, Encounter encounter)
        {
            this.userPokemon = userPokemon;
            this.encounter = encounter;
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
            startOfTurn();
        }

        public void startOfTurn()
        {
            BattleMessage = "";
            if (!isPlayerTurn)
            {
                AttackPhase(enemyPokemon.SelectRandomMove());
            }
            else
            {
                Console.WriteLine("Select a Move:");
                for(int i = 0; i < userPokemon.Moves.Count; i++)
                {
                    Console.WriteLine(userPokemon.Moves[i]);
                }
                int selection = int.Parse(Console.ReadLine());

                while(selection == 3)
                {
                    if(encounter.GetType() == typeof(WildEncounter))
                    {
                        WildEncounter enc = (WildEncounter)encounter;
                        if(enc.TryCapture())
                        {
                            BattleMessage += "Successfully captured " + enc.ActivePokemon + "!\n";
                            selection = -1;
                            EndOfTurn();
                        }
                        else
                        {
                            BattleMessage += "Failed to capture " + enc.ActivePokemon + "\n";
                            selection = -1;
                            EndOfTurn();
                        }
                    }
                    else
                    {
                       Console.WriteLine("Can't capture a Trainer Pokemon");
                        Console.Write("Select a Move:");
                        selection = int.Parse(Console.ReadLine());
                    }
                }
                if (selection != 3 || selection != -1)
                {
                    AttackPhase(userPokemon.Moves[selection]);
                }
            }
        }

        public void AttackPhase(Move selectedMove)
        {
            double damage;
            if (isPlayerTurn)
            {
                damage = userPokemon.ExecuteAttack(enemyPokemon, selectedMove);
                BattleMessage += userPokemon + " attacked with " + selectedMove + "\n";
                BattleMessage += enemyPokemon + " received " + damage + " damage\n";
            }
            else
            {
                damage = enemyPokemon.ExecuteAttack(userPokemon, selectedMove);
                BattleMessage += enemyPokemon + " attacked with " + selectedMove + "\n";
                BattleMessage += userPokemon + " received " + damage + " damage\n";
            }
            moveCount++;
            EndOfTurn();
        }

        public void EndOfTurn()
        {
            Console.WriteLine(BattleMessage);
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
            //if (userVictory)
            //{
            //    MessageBox.show(encounter.ShowReward());
            //}
            //else
            //{
            //    MessageBox.show("I'm sorry, you have lost the game.");
            //}

            if (userVictory)
            {
                Console.WriteLine(encounter.GetReward());
            }
            else
            {
                Console.WriteLine("I'm sorry, you have lost the game.");
            }
        }
    }
}
