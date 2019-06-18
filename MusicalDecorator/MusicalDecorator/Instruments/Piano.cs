using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalDecorator.Instruments
{
    class Piano : Instrument
    {
        public Piano()
        {
            type = "Piano";
            brand = "Yakuza";
            melody = "tum-tum-tum";
            skills = 2;
        }
        public Piano(string type, string brand, string melody, int skills) : base(type, brand, melody, skills)
        {

        }
    }
}
