using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab
{
    abstract class GameBuilder
    {
        public Game Game { get; private set; }
        public void CreateNewGame()
        {
            Game = new Game();
        }
        // Метод, який повертає готову гру
        public Game GetMyGame()
        {
            return Game;
        }
        public abstract void SetPlayers();
        public abstract void SetObjects();
        public abstract void SetMoves();
    }
}
