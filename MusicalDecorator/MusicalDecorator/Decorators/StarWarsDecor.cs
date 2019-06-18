using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MusicalDecorator.Decorators
{
    class StarWarsDecor : InstrmntDecorator
    {
        public StarWarsDecor(Instrument decoratedInstr) : base(decoratedInstr)
        {
            skills = decoratedInstr.Skills + 2;
        }
        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("StarWars sounds");
            StarWarsInConsole();
            base.Sound();
        }
        private static void StarWarsInConsole()
        {
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(250, 500);
            Thread.Sleep(50);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(250, 500);
            Thread.Sleep(50);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
            Thread.Sleep(50);
        }
    }
}
