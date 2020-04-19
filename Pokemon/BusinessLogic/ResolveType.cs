using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

//Angela Susilo
/*ResolveType.cs is a static class that acquires json data from TypeTable.txt.
 For now, only 5 Types are available in the table*/

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
