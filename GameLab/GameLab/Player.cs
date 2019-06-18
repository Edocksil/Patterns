using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab
{
    class Player
    {
        string name;
        int hp, bounty;

        public Player()
        {
            name = "Гравець";
            hp = 3;
            bounty = 0;
        }

        public Player(string name)
        {
            this.name = name;
            hp = 3;
            bounty = 0;
        }

        public string Name { get { return name; } set { name = value; } }

        public void Heal()
        {
            hp += 1;
        }

        public void Injure()
        {
            hp -= 1;
        }

        public int HPnow { get { return hp; } }

        public void BountyGot()
        {
            bounty += 100;
        }

        public int BountyNow { get { return bounty; } }

        public override string ToString()
        {
            return "Гравець-" + name;
        }
    }
}
