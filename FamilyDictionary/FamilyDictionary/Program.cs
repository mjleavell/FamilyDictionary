using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Define a Dictionary that contains information about several members 
            // of your family. Use the following example as a template.
            // EXAMPLE: Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            // myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "42" } });

            Dictionary<string, Dictionary<string, string>> LeavellFamily = new Dictionary<string, Dictionary<string, string>>();

            LeavellFamily.Add("twin", new Dictionary<string, string>() { { "name", "Neely" }, { "age", "25" } });
            LeavellFamily.Add("sister", new Dictionary<string, string>() { { "name", "Lee" }, { "age", "28" } });

            // 2. Next, iterate over each item in myFamily and produce the following output.
            // EXAMPLE: Krista is my sister and is 42 years old
            foreach (var (key, value) in LeavellFamily)
            {
                Console.WriteLine($"{LeavellFamily[key]["name"]} is {LeavellFamily[key]["age"]}");
            }

            Console.ReadLine();
        }
    }
}
