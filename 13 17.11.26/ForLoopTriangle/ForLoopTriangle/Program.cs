namespace ForLoopTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loome tärnidest püramiidid");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                    for (int j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                
                Console.Write("\n");
            }
            for (int i = n; i >= 0; i--)
            {
                    for (int j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }

                Console.Write("\n");
            }
        }
    }
}
