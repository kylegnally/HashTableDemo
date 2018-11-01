using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_extra_hash_table_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericHashMap<int, string> valleyNumToName = new GenericHashMap<int, string>();
            //Console.SetBufferSize(80, 1200);

            Console.WriteLine("Adding some entries to the HashMap");
            Console.WriteLine("EX: valleyNumToName.Put(12345, \"David Barnes\"");
            valleyNumToName.Put(12345, "James Kirk");
            valleyNumToName.Put(23456, "Benjamin Sisko");
            valleyNumToName.Put(34567, "Kathryn Janeway");
            valleyNumToName.Put(45678, "Jean-Luc Picard");
            valleyNumToName.Put(56789, "Jonathan Archer");

            Console.WriteLine("The created hash table");
            Console.WriteLine(valleyNumToName.ToString());
            Console.WriteLine();
            Console.WriteLine(valleyNumToName.ShowArray());

            Console.WriteLine("********************************");

            Console.WriteLine("Get a single value out from the hash table from the key");
            Console.WriteLine("valleyNumToName.Get(45678)");
            Console.WriteLine(valleyNumToName.Get(45678));
            Console.WriteLine();

            Console.WriteLine("What if we add 2 entries that map to the same location");
            Console.WriteLine("valleyNumToName.Put(26189, \"First Entry\")");
            Console.WriteLine("valleyNumToName.Put(26092, \"Second Entry\")");
            valleyNumToName.Put(26189, "First Entry");
            valleyNumToName.Put(26092, "Second Entry");

            Console.WriteLine(valleyNumToName.ToString());
            Console.WriteLine(valleyNumToName.ShowArray());

            Console.WriteLine("Let's get the first entry out");
            Console.WriteLine("valleyNumToName.Get(26189)");
            Console.WriteLine(valleyNumToName.Get(26189));
            Console.WriteLine("Got the second entry instead of the first due to collision");

            // *****************************************************
            Dictionary<int, string> valleyDictionary = new Dictionary<int, string>();

            valleyDictionary[26189] = "First Entry";
            valleyDictionary[26092] = "Second Entry";
            Console.WriteLine("Use built in dictionary now with same first / second entry");
            Console.WriteLine(valleyDictionary[26189]);
            Console.WriteLine(valleyDictionary[26092]);
            Console.WriteLine("It is smart enough to retain without overwrite");

            // ****************************************************

            Dictionary<string, GenericHashMap<decimal, string>> foobar = new Dictionary<string, GenericHashMap<decimal, string>>();
        }
    }
}
