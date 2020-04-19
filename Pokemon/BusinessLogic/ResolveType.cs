using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Pokemon
{
    public static class ResolveType
    {
        private static String data = File.ReadAllText($"./Assets/TypeTable.txt"); // change this according to file location
        private static readonly Dictionary<string, Dictionary<string, double>> TypeTable = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, double>>>(data);

        public static double TypeMultiplier(String attacker, String defender)
        {
            return TypeTable[attacker][defender];
        }
    }
}
