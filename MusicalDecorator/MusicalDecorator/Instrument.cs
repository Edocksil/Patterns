using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalDecorator
{
    class Instrument
    {
        protected string type, brand, melody;
        protected int skills;

        public Instrument(){}

        public Instrument(string type, string brand, string melody, int skills)
        {
            this.type = type;
            this.brand = brand;
            this.melody = melody;
            this.skills = skills;
        }

        public virtual void Sound()
        {
            Console.WriteLine(melody);
        }

        public string Melody { get { return melody; } }

        public string Type { get { return type; } }
        public string Brand { get { return brand; } }
        public int Skills { get { return skills; } }

        public override string ToString()
        {
            return type + " by " + brand + ". Demo: " + melody + ". Skills lvl: " + skills;
        }
    }
}
