using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_NetworKing.Elements
{
    class Server : IElement
    {
        int amount;
        readonly int value = 200;

        public Server()
        {
            amount = 10;
        }

        public Server(int amount)
        {
            this.amount = amount;
        }

        public int Cost() { return value * amount; }

        public override string ToString()
        {
            return "Патужна Машина! (SERVER)" + "\r\n" + "У кількості: " + amount;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
