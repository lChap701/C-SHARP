using System;
using System.Collections.Generic;
using System.Text;

namespace FormWithInstaintableClass
{
    class Game
    {
        private int power;
        private string gamerTag;
        private string gameName;
        private double gameCost;

        public Game() : this(1, "Some Gamer Tag", "Some Gamer Name", 20)    // constructor intializer
        {
           /* power = 1;
            gamerTag = "Some Gamer Tag";
            gamerTag = "Some Gamer Name";
            gameCost = 20;*/
        }

        public Game(int power, string gamerTag, string gameName, double gameCost)
        {
            Power = power;
            GamerTag = gamerTag;
            this.gameName = gameName;
            this.gameCost = gameCost;
        }

        public int Power    // property
        {
            get
            {
                return power;
            }

            set
            {
                if (value > 0)
                {
                    power = value;
                }
                else
                {
                    power = 1;
                }
            }

        }

        public string GamerTag { get => gamerTag; set => gamerTag = value; }    
    }
};
