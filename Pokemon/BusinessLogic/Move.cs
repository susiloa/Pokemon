using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

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
