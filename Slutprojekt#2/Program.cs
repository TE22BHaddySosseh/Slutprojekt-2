using System;

namespace PrincessGame
{
    class Program
    {
        static void Main(string[] args){
            gamerunning = true;

            while (gamerunning)
            {
                gamerunning = GameMethods.StartGame();
            }
        }
        
    }
}