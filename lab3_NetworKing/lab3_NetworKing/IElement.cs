using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_NetworKing
{
    interface IElement
    {
        int Cost();

        void Accept(IVisitor visitor);
    }
}
