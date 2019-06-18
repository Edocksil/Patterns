using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_NetworKing
{
    interface IVisitor
    {
        void Visit(IElement element);

        //void Visit(Elements.Server server);
        //void Visit(Elements.Computer comp);
        //void Visit(Elements.Wire wire);
    }
}
