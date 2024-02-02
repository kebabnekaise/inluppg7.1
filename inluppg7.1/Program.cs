using System;
using System.Reflection.Metadata.Ecma335;

namespace inluppg7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in namn. Tomrad för att avsluta");
            List<string> ordLista = new List<string>();

            string entry = "a";
            while(entry != "")
            {
                entry = Console.ReadLine();
                if (entry != "")
                {
                    ordLista.Add(entry);
                }

            }
            ordLista.Sort();
            PrintFlip(ordLista);



        }

        static void PrintFlip(List<string> strings)
        {

            for (int i = strings.Count() - 1; i >= 0; i--)
            {
                Console.WriteLine(strings[i]);
            }
        }
    }
}