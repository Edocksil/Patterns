using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_NetworKing
{
    class Calculator : IVisitor
    {
        public int Cost { get; private set; }

        public void Visit(IElement elem)
        {
            Console.WriteLine(elem.ToString());
            Cost += elem.Cost();
            Console.WriteLine("Поточна вартість мережі: " + Cost.ToString());
        }


    }
}
