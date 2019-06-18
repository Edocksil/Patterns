using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab.GameObjects
{
    class Monster : IObject
    {
        string text;
        public void Action(Player player)
        {
            text = "DANGER: ви натрапили на монстра!\r\nЗараз буде битва!";
            Journal.getInstance().LogNow(player, text);
            text += Fight(player);
            Journal.getInstance().LogNow(player, text);
        }

        private static Random rnd = new Random();
        string Fight(Player player)
        {
            string[] results = new string[] { "win", "lose" };
            switch (results[rnd.Next(0, results.Length)])
            {
                case "win":
                    {
                        player.BountyGot();
                        return text = "Вітаю, ви перемогли. Отрмайте нагороду +100₴";
                    };
                case "lose":
                    {
                        player.Injure();
                        return text = "На жаль, Ви програли! Монстр зробив вам 'кусь': -1 НР";
                    }
                default:
                    throw new Exception("помилка рандому");
            }
        }

        public override string ToString()
        {
            return "Монстр";
        }
    }
}
