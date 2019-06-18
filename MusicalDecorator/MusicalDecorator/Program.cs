using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Instruments.Piano klavishi = new Instruments.Piano("piano", "toskiba", "tiz-driz", 3);
            klavishi.Sound();

            Console.WriteLine("\n----------------------------------\n");

            Decorators.StarWarsDecor laser = new Decorators.StarWarsDecor(klavishi);
            laser.Sound();

            Console.WriteLine(klavishi.ToString());
            Console.WriteLine("\n----------------------------------\n");

            Instruments.Guitar fender = new Instruments.Guitar();
            fender.Sound();
            Console.WriteLine("\n----------------------------------\n");

            laser = new Decorators.StarWarsDecor(fender);
            laser.Sound();
            Console.WriteLine(fender.ToString());
            Console.WriteLine("\n----------------------------------\n");

            Decorators.MissionImposDecor mission = new Decorators.MissionImposDecor(fender);
            mission.Sound();

            Console.WriteLine("\n----------------------------------\n");
            mission = new Decorators.MissionImposDecor(laser);//2 декоратори одночасно - по черзі грають
            mission.Sound();

            Console.WriteLine("\n----------------------------------");
            Instruments.Drum kastrulya = new Instruments.Drum();
            Console.WriteLine(kastrulya);
            Decorators.RapDecor rapper = new Decorators.RapDecor(kastrulya); //дуже специфічний барабан з репером поряд
            rapper.Sound();
            
            Console.ReadKey();
        }
    }
}
