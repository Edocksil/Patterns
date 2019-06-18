using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab.TemplateGame
{
    class GameFor3 : GameBuilder
    {
        public override void SetPlayers()
        {
            this.Game.Players = new Player[3];
            for (int i = 0; i < Game.Players.Length; i++)
            {
                Game.Players[i] = new Player();
            }
        }
        public override void SetMoves()
        {
            Game.Moves = Game.Players.Length * 5;
        }

        private static Random rnd = new Random();

        public override void SetObjects()
        {
            Game.GameObjects = new IObject[Game.Players.Length * 30];

            string[] gameFieldObjects = new string[] {
                "empty",
                "bounty",
                "heal",
                "empty",
                "monster",
                "trap",
                "empty"
            };
            for (int i = 0; i < Game.GameObjects.Length; i++)
            {
                switch (gameFieldObjects[rnd.Next(0, gameFieldObjects.Length)])
                {
                    case "empty":
                        Game.GameObjects[i] = new GameObjects.EmptySquare();
                        break;
                    case "bounty":
                        Game.GameObjects[i] = new GameObjects.Bounty();
                        break;
                    case "heal":
                        Game.GameObjects[i] = new GameObjects.Heal();
                        break;
                    case "monster":
                        Game.GameObjects[i] = new GameObjects.Monster();
                        break;
                    case "trap":
                        Game.GameObjects[i] = new GameObjects.Trap();
                        break;
                    default:
                        throw new Exception("помилка заповнення масив Ігрових Об'єктів");
                }
            }
        }
    }
}
