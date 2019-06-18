using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalDecorator
{
    class InstrmntDecorator : Instrument
    {
        protected Instrument DecoratedInstrument { get; set; }

        public InstrmntDecorator(Instrument decoratedInstr)
        {
            DecoratedInstrument = decoratedInstr;
        }
        public override void Sound()
        {
            DecoratedInstrument.Sound();
        }
    }
}
