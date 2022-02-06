using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public static class ConsoleManager
    {
        public static void SetConsole()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

        }

        public static bool EndGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string(' ', 55) + "! YOU LOST !");
            Console.Beep(2200, 700);

            return true;
        }

        public static void DrawApple(int row, int col)
        {
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write('O');
        }

        public static void DrawBorder()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BufferHeight = 30;
            Console.BufferWidth = 122;

            Console.WriteLine(new string('=', 122));
            for (int i = 1; i < Console.BufferHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('|');
            }
            for (int i = 0; i < Console.BufferWidth; i++)
            {
                Console.SetCursorPosition(i, Console.BufferHeight - 1);
                Console.Write('=');
            }
            for (int i = 1; i < Console.BufferHeight - 1; i++)
            {
                Console.SetCursorPosition(Console.BufferWidth - 1, i);
                Console.Write('|');
            }
            Console.ForegroundColor = ConsoleColor.Red;

        }

    }
}
