using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace PlayBall
{
    /// <summary>
    /// Created 8/31/2020 by Lucas Chapman.
    /// This class is used to provide updated information for 12 baseball players and display data for all 12 baseball 
    /// players. A two-dimensional array is used to contain all of the data (except for their player number) for each 
    /// player and a external file is used to contain the names of each player (the names of each player are stored in 
    /// the array of players at the start of the program).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * The players array is used to store information about each player (not including the player number)
             * Note: an object array can be use to store different data types, but all data in the array will be 
             * considered an object
             */
            object[,] players = new object[12, 3];  // "3" used for the 3 fields: name, times at bats, and number of hits
            char close = 'N';   // used to run the loop

            Init(players);

            // Loop that keeps the program running
            while (close == 'N')
            {
                // Gets the option that was selected by the user and validates it 
                WriteLine("Please select an option:\n1 - Update Information For Player(s)\n2 - Display All 12 Players" +
                    "\n3 - Exit");
                string opt = ReadLine();

                switch (opt)
                {
                    case "1":
                        Opt1(players);
                        break;
                    case "2":
                        Opt2(players);
                        break;
                    case "3":
                        close = CloseProgram(); // closes the program based on what the user entered  
                        break;
                    case "":
                        WriteLine("Nothing was entered, press Enter to try again");
                        ReadLine();
                        break;
                    default:
                        WriteLine("An invalid option was selected, press Enter to try again");
                        ReadLine();
                        break;
                }
            }
        }

        /// <summary>
        /// Displays a welcome message and adds values to the players array
        /// </summary>
        /// <param name="players">Represents the array of players</param>
        static void Init(object[,] players)
        {
            // Displays the welcome message
            WriteLine("Welcome to the Play Ball Program!\n");

            ReadFile(players);

            // Sets all numeric fields in the array to 0
            for (int i = 0; i < 12; i++)
            {
                players[i, 1] = 0;
                players[i, 2] = 0;
            }
        }

        /// <summary>
        /// Reads the player names in the external file "player_names.dat" and stores each name in the array
        /// </summary>
        /// <param name="names">Represents the array of players</param>
        static void ReadFile(object[,] names)
        {
            const string FILENAME = "player_names.dat"; // declared here so it can be used in both try and catch blocks

            // Gets the names of all players in the DAT file and then closes the StreamReader when finished
            try
            {
                StreamReader reader = new StreamReader(FILENAME);
                string ln;  // stores the contents of each line in the file
                int i = 0;

                // EOF loop
                while ((ln = reader.ReadLine()) != null)
                {
                    names[i, 0] = ln;
                    i++;
                }
                reader.Close(); // closes the StreamReader
            }
            catch (Exception)
            {
                WriteLine("The " + FILENAME + " file was not found\nPress Enter to close the program");
                ReadLine();
                System.Environment.Exit(1); // closes the program
            }
        }

        /// <summary>
        /// Prompts the user to enter all the required fields (player number, times at bat, and number of hits)
        /// </summary>
        /// <param name="player">Represents the array of players</param>
        static void Opt1(object[,] player)
        {
            char input = ' ';

            // Loops until the user enters a "N"
            while (input != 'N')
            {
                int playerNum = PlayerNum();
                int atBat = AtBat();
                int hits = Hits(atBat);

                // Accumulates the values of atBat and hits to the player array using playerNum as a subscript.
                player[playerNum - 1, 1] = atBat + (int)player[playerNum - 1, 1];    // doesn't use "+=" because the data in the array is considered an object
                player[playerNum - 1, 2] = hits + (int)player[playerNum - 1, 2];

                // Asks the user if they want to update information for more players
                input = Cont(); // determines if the loop should continue or end
            }
        }

        /// <summary>
        /// Gets a valid number that was entered to be used as the player number
        /// </summary>
        /// <returns>Returns a valid player number</returns>
        static int PlayerNum()
        {
            int num = 0;
            bool valid = false;

            // Continues to prompt the user until a valid number is entered
            while (!valid)
            {
                try
                {
                    WriteLine("Please enter the player's number:");
                    num = int.Parse(ReadLine());    // converts what was entered to an integer if possible

                    // Checks if the number that was entered is between 1 and 12
                    if (num > 0 && num <= 12)
                    {
                        valid = true;
                    }
                    else
                    {
                        WriteLine("The player number should be less than 12 and greater than 0, press Enter to " +
                            "continue");
                        ReadLine();
                    }
                }
                catch (Exception)
                {
                    WriteLine("Error, a number was not entered\nPress Enter to continue");
                    ReadLine();
                }
            }

            return num;
        }

        /// <summary>
        /// Gets a valid number that was entered to be used as the amount of times a player has been at bat
        /// </summary>
        /// <returns>Returns a valid number</returns>
        static int AtBat()
        {
            int num = 0;
            bool valid = false;

            // Continues to prompt the user until a valid number is entered 
            while (!valid)
            {
                try
                {
                    WriteLine("Please enter the number of times the player has been at bat:");
                    num = int.Parse(ReadLine());

                    // Checks if the number that was entered is too low
                    if (num >= 0)
                    {
                        valid = true;
                    }
                    else
                    {
                        WriteLine("The number that was entered is too low, it should be greater than or equal to 0" +
                            "\nPress Enter to enter a different number");
                        ReadLine();
                    }
                }
                catch (Exception)
                {
                    WriteLine("Error, a number was not entered\nPress Enter to continue");
                    ReadLine();
                }
            }

            return num;
        }

        /// <summary>
        /// Gets a valid number that was entered to be used as the amount of times a player has hit the ball
        /// </summary>
        /// <param name="bat">Represents the number of times a player has been at bat</param>
        /// <returns>Returns a valid number</returns>
        static int Hits(int bat)
        {
            int num = 0;
            bool valid = false;

            // Continues to prompt the user until a valid number is entered
            while (!valid)
            {
                try
                {
                    WriteLine("Please enter the number of times the player has hit the ball:");
                    num = int.Parse(ReadLine());

                    // Checks if the number enter is less than "bat" and is not too low
                    if (num <= bat)
                    {
                        if (num >= 0)
                        {
                            valid = true;
                        }
                        else
                        {
                            WriteLine("The number you entered is too low, it should be greater than or equal to 0" +
                                "\nPress Enter to enter a different number");
                            ReadLine();
                        }
                    }
                    else
                    {
                        WriteLine("The number you entered is too high, it should not exceed " + bat + "\nPress Enter " +
                            "to enter a different number");
                        ReadLine();
                    }
                }
                catch (Exception)
                {
                    WriteLine("Error, a number was not entered\nPress Enter to continue");
                    ReadLine();
                }
            }

            return num;
        }

        /// <summary>
        /// Checks if the user wishes to continue entering updated information for players
        /// </summary>
        /// <returns>Returns a "Y" or "N"</returns>
        static char Cont()
        {
            string data = "";
            bool valid = false;

            // Continues to prompt the user until either a "Y" or "N" is entered
            while (!valid)
            {
                WriteLine("Do you wish to continue updating information for players?\nY - Yes\nN - No");
                data = ReadLine();

                // Checks if either a "Y" or "N" was entered
                if (data.ToUpper().Equals("Y") || data.ToUpper().Equals("N"))   // ToUpper() used to force data to uppercase
                {
                    valid = true;
                }
                else if (string.IsNullOrEmpty(data))    // checks if "data" is empty ("") or null
                {
                    WriteLine("Nothing was entered, press Enter to try again");
                    ReadLine();
                }
                else
                {
                    WriteLine("Unknown \"" + data + "\" was entered, press Enter to try again");
                    ReadLine();
                }
            }

            return char.Parse(data.ToUpper());  // if a "y" or "n" is entered, it will be forced to uppercase
        }

        /// <summary>
        /// Gets the batting average and displays the data of all 12 player
        /// </summary>
        /// <param name="players">Represents the array of players</param>        
        static void Opt2(object[,] players)
        {
            // Writes the column headings
            WriteLine("\n{0, -15} {1, 10} {2, 6} {3, 10} {4, 5} {5, 10} {6, 7}\n", "Name", " ", "At Bat", " ", "Hits",
                " ", "Average");

            // Prints out all of the players and formats all numeric data
            for (int i = 0; i < 12; i++)
            {
                double batAvg = CalcBatAvg(players, i);
                int bat = (int)players[i, 1];    // stores values in int variables to be able to format data
                int hits = (int)players[i, 2];

                // Writes data for each column
                WriteLine("{0, -15} {1, 10} {2, 6} {3, 10} {4, 5} {5, 10} {6, 7}", players[i, 0], " ",
                    bat.ToString("##,##0"), " ", hits.ToString("#,##0"), " ", batAvg.ToString("#.000"));
            }

            WriteLine("\nPress Enter to return to the main menu");
            ReadLine(); // used to give the user a chance to read what is on the screen
        }

        /// <summary>
        /// Calculates the batting average
        /// </summary>
        /// <param name="player">Represents the array of players</param>
        /// <param name="i">Represents the iterator (used as a subscript for the players array)</param>
        /// <returns>Returns the batting average that was calculated</returns>
        static double CalcBatAvg(object[,] player, int i)
        {
            double avg;
            int atBat = (int)player[i, 1];  // converts the data in the array to an int and stores it in variables
            int hits = (int)player[i, 2];

            // Determines if the batting average should be calculated or just set to 0
            if (atBat > 0)  // used to avoid dividing by 0
            {
                avg = (double)hits / atBat;    // converts result to a double since integer math is used
            }
            else
            {
                avg = 0;
            }

            return avg;
        }

        /// <summary>
        /// Determines if the user chose to close the program
        /// </summary>
        /// <returns>Returns either a "Y" or "N"</returns>
        static char CloseProgram()
        {
            bool valid = false;
            char data = ' ';

            // Continues to prompt the user until they enter either a "Y" or "N"
            while (!valid)
            {
                WriteLine("You have chosen to leave this program, do you wish to continue?\nY - Yes\nN - No");
                string input = ReadLine();

                // Checks if what was entered was either a "Y" or a "N"
                if (string.IsNullOrEmpty(input))    // checks if input is empty ("") or null
                {
                    WriteLine("Nothing was entered, press Enter to try again");
                    ReadLine();
                }
                else if (!input.ToUpper().Equals("Y") && !input.ToUpper().Equals("N"))  // ToUpper() is used to force data to uppercase
                {
                    WriteLine("Unknown data \"" + input + "\", press Enter to try again");
                    ReadLine();
                }
                else
                {
                    data = char.Parse(input.ToUpper()); // converts data to a char in uppercase
                    valid = true;
                }
            }

            return data;
        }
    }
}