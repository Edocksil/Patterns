using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab
{
    class Game
    {
      //  private int movesCount;
        public int Moves { get; set; }

      //  private Player[] players;
        public Player[] Players { get; set; }

       // private IObject[] gameObjects;
        public IObject[] GameObjects { get; set; }

        public Game()
        {

        }
    }
}
