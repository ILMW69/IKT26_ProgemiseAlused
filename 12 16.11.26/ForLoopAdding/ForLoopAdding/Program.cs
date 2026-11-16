namespace ForLoopAdding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta korduste arv");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\n\n");

            int kordus = int.Parse(Console.ReadLine());

            Console.Clear();
            for (int i = 1; i <= kordus; i++)
            {
                /*if (i % 3 == 0)
                {
                    Console.WriteLine("killadi - koll");
                }
                else
                {
                    Console.WriteLine("kill - koll");
                }*/

                Console.WriteLine("See on rida number " + i);

                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("kill - koll");
                }
                Console.WriteLine("killadi - koll");
            }
        }
    }
}
