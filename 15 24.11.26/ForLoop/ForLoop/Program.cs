namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kõrgus");
            if (!int.TryParse(Console.ReadLine(), out int height) || height < 3) 
            {
                Console.WriteLine("sisesta täisarv");
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int row = 1; row <= height ; row ++)
            {
                for (int empty = 1; empty <= height - row; empty++)
                {
                    Console.Write(" ");
                }

                for (int location = 1; location <= 2 * row - 1; location++)
                {
                    bool thing =
                        (row == 2 && location == 1) || 
                        (row == height - 1 && location == 2 * row - 1) ||
                        (row == height && location == row);

                    if (thing)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    Console.Write(thing ? "o" : "*");
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int row = 1; row <= 2; row++)
            {
                for (int empty = 1; empty < height; empty++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            Console.ResetColor();
        }
    }
}
