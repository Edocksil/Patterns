using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab
{
    class GameDirector
    {
        private GameBuilder builder;
        public void CreateBuilder(GameBuilder builder)
        {
            this.builder = builder;
        }
        public Game GetGame()
        {
            builder.CreateNewGame();
            builder.SetPlayers();
            builder.SetObjects();
            builder.SetMoves();
            return builder.GetMyGame();
        }
        //public void CreateGame()
        //{
        //    builder.CreateNewGame();
        //    builder.SetPlayers();
        //    builder.SetObjects();
        //    builder.SetMoves();
        //}
    }
}
