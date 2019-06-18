using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalDecorator.Instruments
{
    class Guitar : Instrument
    {
        public Guitar()
        {
            type = "Guitar";
            brand = "Fender";
            melody = "trun`-dzin`-tdsh";
            skills = 3;
        }
        public Guitar(string type, string brand, string melody, int skills) : base(type, brand, melody, skills)
        {

        }
    }
}
