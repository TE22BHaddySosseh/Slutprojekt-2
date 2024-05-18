using System;

namespace PrincessGame
{
    class Program
    {
        gamerunning = true;

        while (gamerunning)
        {
            gamerunning = GameMethods.StartGame();
        }
    }
}