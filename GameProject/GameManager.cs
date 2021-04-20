using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " oyun sepete eklendi. ");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " oyun güncellendi. ");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " oyun silindi. ");
        }
    }
}
