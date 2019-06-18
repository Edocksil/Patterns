using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_NetworKing.Elements
{
    class Network
    {
        private readonly List<IElement> elements = new List<IElement>();
        public string Name { get; set; }
        public string Chief { get; set; }

        public Network()
        {
            Name = "ІОЦ";
            Chief = "Мар'яновський";
        }

        public Network(string name, string chief)
        {
            Name = name;
            Chief = chief;
        }

        public void Add(IElement elem)
        {
            elements.Add(elem);
        }

        public void Remove(IElement elem)
        {
            elements.Remove(elem);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (IElement elem in elements)
                elem.Accept(visitor);
        }

        public override string ToString()
        {
            return "Мережа " + Name + " ; Відповідальний: " + Chief; ;
        }
    }
}
