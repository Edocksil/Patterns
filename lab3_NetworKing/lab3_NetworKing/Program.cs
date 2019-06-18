using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_NetworKing
{
    class Program
    {
        static void Main(string[] args)
        {
            Elements.Network ICC = new Elements.Network();

            ICC.Add(new Elements.Server(3));
            ICC.Add(new Elements.Computer(5));
            ICC.Add(new Elements.Wire(100));

            Console.WriteLine(ICC.ToString());
            ICC.Accept(new Calculator());

            Console.WriteLine();

            Elements.Network dark = new Elements.Network("DarkNet", "Durov");

            dark.Add(new Elements.Server(666));
            dark.Add(new Elements.Computer(1));
            dark.Add(new Elements.Wire(7));

            Console.WriteLine(dark.ToString());
            dark.Accept(new Calculator());

            Console.ReadKey();
        }
    }
}
