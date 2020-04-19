using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace PokemonConsole
{
    class Program
    {

        static void Main()
        {
            List < Pokemon > pokemons = Pokemon.GetPokemons();

            Console.WriteLine("Welcome to Pokemon Console Game!");
            Console.WriteLine("Please Select a pokemon to battle with from the list:");
            for (int i = 0; i < pokemons.Count; i++)
            {
                Console.WriteLine(i + ". " + pokemons[i]);
            }
            Console.WriteLine();
            Console.Write("Selection: ");
            int selectedI = int.Parse(Console.ReadLine());
            Pokemon userPokemon = pokemons[selectedI];
            pokemons.RemoveAt(selectedI);

            int ent = new Random().Next(1, 3);
            Encounter encounter;
            if(ent == 1)
            {
                int enemySelected = new Random().Next(pokemons.Count);
                encounter = new WildEncounter(pokemons[enemySelected], "100 EXP");
                Console.WriteLine("You have encountered a wild " + pokemons[enemySelected]);
            }
            else
            {
                List<Pokemon> enemyPokemon = new List<Pokemon>();
                while(enemyPokemon.Count < 2)
                {
                    int selected = new Random().Next(pokemons.Count);
                    enemyPokemon.Add(pokemons[selected]);
                    pokemons.RemoveAt(selected);
                }
                encounter = new TrainerEncounter(enemyPokemon, "600 EXP and $56");
                Console.WriteLine("You have encountered Trainer Alex");
            }

            Battle battle = new Battle(userPokemon, encounter);
            battle.BattleStart();

            Console.WriteLine("Battle Ended");
        }

        static void backup(string[] args)
        {

            Console.Write("Attacker Type: ");
            String attacker = Console.ReadLine();
            Console.Write("Defender Type: ");
            String defender = Console.ReadLine();

            Console.WriteLine("Multiplier becomes {0}", ResolveType.TypeMultiplier(attacker, defender));

            String moveData = File.ReadAllText(@"./MoveTable.txt");
            List<Move> moveList = JsonConvert.DeserializeObject<List<Move>>(moveData);

            String pokemonData = File.ReadAllText(@"./PokemonTable.txt");
            List<Pokemon> pokemonList = JsonConvert.DeserializeObject<List<Pokemon>>(pokemonData);

            Console.WriteLine(moveList[3].Name + "(" + moveList[3].Type + "): " + moveList[3].Power);

            Console.WriteLine(pokemonList[4].Name + "(" + pokemonList[4].Type + "): " + pokemonList[4].Moves[2].Name);
        }
    }
}
