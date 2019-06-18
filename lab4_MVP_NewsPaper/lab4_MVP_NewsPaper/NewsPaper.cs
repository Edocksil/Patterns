using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_MVP_NewsPaper
{
    class NewsPaper : IData
    {
        public string Name { get; private set; }
        public int Cost { get; private set; }
        public bool IsPaid { get; private set; }

        public NewsPaper(string name, int cost)
        {
            Name = name;
            Cost = cost;
            IsPaid = false;
        }

        //відмітка у формі податкової та перевірка на вартість
        public bool TaxForm(int payment)
        {
            return payment >= Cost;
        }

        public override string ToString()
        {
            return Name + " costs: " + Cost;
        }
    }
}
