using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_NetworKing.Elements
{
    class Wire : IElement
    {
        int amount;
        readonly int value = 5; 

        public Wire()
        {
            amount = 10;
        }

        public Wire(int amount)
        {
            this.amount = amount;
        }

        public int Cost() { return value * amount; }

        public override string ToString()
        {
            return "Мережевий Шланг! (WIRE)" + "\r\n" + "Метрів: " + amount; ;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
