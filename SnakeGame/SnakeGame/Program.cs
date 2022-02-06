using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose difficulty from 1 to 100 ");
            int difficulty = int.Parse(Console.ReadLine());
            Console.Write("Do you want to play with border? [y/n] ");
            string border = Console.ReadLine();
            string drawBorder = "n";
            if (border == "y")
            {
                Console.Write("Do you want to draw the border? (It lags more with it) [y/n] ");
                drawBorder = Console.ReadLine();
            }

            Console.WriteLine("Click right or down arrow to start the game");


            Snake snake = new Snake();
            snake.SnakeElements.AddFirst(new SnakeElement()
            {
                Character = '@',
                Position = new Position(1, 1)
            });


            snake.DrawSnake(100 - difficulty, border, drawBorder);


            Console.ReadLine();
        }
    }
}
