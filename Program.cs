using System;

namespace CSharpTDDTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string empty = BasicCanonizer.getCanonicalSearch(" ");
            Console.WriteLine(empty== "");
            empty = BasicCanonizer.getCanonicalSearch(" ");
            Console.WriteLine(empty == "");
            empty = BasicCanonizer.getCanonicalSearch("       ");
            Console.WriteLine(empty == "");
            Console.WriteLine(BasicCanonizer.getCanonicalSearch(" Arsenal Football Club  "));
            Console.WriteLine(BasicCanonizer.getCanonicalSearch(" Arsenal      Football        Club       "));
            Console.WriteLine(BasicCanonizer.getCanonicalSearch("Arsenal FC"));
            Console.WriteLine(BasicCanonizer.getCanonicalSearch("Arsenal Football Club"));
            Console.WriteLine(BasicCanonizer.getCanonicalSearch("Arsenal FootballClub London"));

            Console.Read();
        }
    }
}
