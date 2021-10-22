using System;
using System.Collections.Generic;
using System.Text;

namespace FormWithInstaintableClass
{
    class TestGame
    {
        static void Main()
        {
            Game myGame = new Game(0, "", "", -1);
            Game newGame = new Game { Power = 1, GamerTag = "tag" };    // object intializer
                                                                        // Game newGame = new Game() { Power = 1, GamerTag = "tag" }    // another way of writting an object intializer
        }
    }
}
