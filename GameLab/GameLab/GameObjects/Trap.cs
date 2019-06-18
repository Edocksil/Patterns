using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab.GameObjects
{
    class Trap : IObject
    {
        string text;
        public void Action(Player player)
        {
            text = "'It`s a trap!': Співчуваю, ви пошкодилися у пастці! -1 НР";
            player.Injure();
            Journal.getInstance().LogNow(player,text);
        }

        public override string ToString()
        {
            return "Пастка";
        }
    }
}
