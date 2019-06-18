using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalDecorator.Instruments
{
    class Drum : Instrument
    {
        public Drum()
        {
            type = "Drum";
            brand = "Kastrulya";
            melody = "bah-bam-bem";
            skills = 1;
        }
        public Drum(string type, string brand, string melody, int skills) : base(type, brand, melody, skills)
        {

        }
    }
}
