using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab.GameObjects
{
    class Bounty : IObject
    {
        string text;
        public void Action(Player player)
        {
            text = "знайшов скарб! Вітаю! +100₴";
            player.BountyGot();
            Journal.getInstance().LogNow(player, text);
        }


        public override string ToString()
        {
            return "Скарб";
        }
    }
}
