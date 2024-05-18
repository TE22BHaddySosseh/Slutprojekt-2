using System;

namespace PrincessGame
{
    class Program
    {
        static void Main(string[] args){
            bool gamerunning = true;

            while (gamerunning)
            {
                GameMethods.Intro();
                GameMethods.EscapeTower();
                GameMethods.PreFight();
                GameMethods.Dragonfight();
            }
        }
        
    }
}