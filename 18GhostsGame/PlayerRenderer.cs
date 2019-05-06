using System;
using System.Collections.Generic;
using System.Text;

namespace _18GhostsGame
{
    class PlayerRenderer
    {

        //Print given text
        public static void PrintText(string text)
        {
            bool color = false;
            foreach (char letter in text)
            {
                if (letter == 'R')
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    color = !color;
                }
                else if (letter == 'B')
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    color = !color;
                }
                else if (letter == 'Y')
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    color = !color;
                }
                if ((letter == ' ' || letter == '>') && color == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    color = !color;
                }

                Console.Write(letter);
            }
        }

        // Just print a new line
        public static void PrintText()
        {
            Console.WriteLine("\n");
        }

    }
}
