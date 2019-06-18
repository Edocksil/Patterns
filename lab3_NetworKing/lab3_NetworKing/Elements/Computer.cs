using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_NetworKing.Elements
{
    class Computer : IElement
    {
        int amount;
        readonly int value = 100;

        public Computer()
        {
            amount = 10;
        }

        public Computer(int amount)
        {
            this.amount = amount;
        }

        public int Cost() { return value * amount; }

        public override string ToString()
        {
            return "Комплюхтєр! (COMPUTER)" + "\r\n" + "У кількості: " + amount; 
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
