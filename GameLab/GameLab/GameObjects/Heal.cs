using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab.GameObjects
{
    class Heal : IObject
    {
        string text;
        public void Action(Player player)
        {
            text = "підлікувався! +1 HP";
            player.Heal();
            Journal.getInstance().LogNow(player, text);
        }

        public override string ToString()
        {
            return "Ліки";
        }
    }
}
