


using ITEAHub.Math.OurMath;
using System;
using System.Collections.Generic;

namespace ITEAHub.Math
{
    class Program 
    {
        static void Main(string[] args)
        {

            var listOfMenu = new List<IMenu>
            {
                new AddMenu(),
                new ExitMenu()
            };
            var game = new Game(listOfMenu);
            game.Start();
        }
    }  


}
