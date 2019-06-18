using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_MVP_NewsPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NewsPaper> data = new List<NewsPaper>{ new NewsPaper("PravDa", 0), new NewsPaper("Slovo", 100),
            new NewsPaper("Vikno", 50)};

            Presenter p = new Presenter(data);

            ViewPapers v = new ViewPapers(p);

            v.Display();

            v.Buy("PravDa", -1);
            v.Buy("Slovo", 100);
            v.Buy("Vikno", 75);

            p.UpdateList(new NewsPaper("FRECS", 228));

            v.Buy("FRECS", 1488);

            Console.ReadKey();

        }
    }
}
