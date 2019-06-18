using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab.GameObjects
{
    class EmptySquare : IObject
    {
        string text;
        public void Action(Player player)
        {
            text = "Пропусти хід - пуста клітинка. Нічого не відбулося";
            Journal.getInstance().LogNow(player, text);
        }

        public override string ToString()
        {
            return "Пуста клітинка";
        }
    }
}
