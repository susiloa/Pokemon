using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

//Author: Oliver Drenth. Properties initialized by Sofia Avancena. Edited by Angela Susilo
/*Move.cs uses json data from MoveTable.txt for each Move (skill)
 and their associated type, accuracy and power that a Pokémon can has.*/

namespace Pokemon
{
    public class Move
    {
        public String Name { get; }
        public String Type { get; }
        public int Acc { get; }
        public int Power { get; }

        public Move(String name, String type, int power, int acc)
        {
            Name = name;
            Type = type;
            Acc = acc;
            Power = power;
        }

        public static List<Move> GetMoves()
        {
            String moveData = File.ReadAllText($"/Assets/MoveTable.txt");
            List<Move> moveList = JsonConvert.DeserializeObject<List<Move>>(moveData);
            return moveList;
        }

        public override string ToString()
        {
            return Name + " (" + Type + ")";
        }
    }
}
