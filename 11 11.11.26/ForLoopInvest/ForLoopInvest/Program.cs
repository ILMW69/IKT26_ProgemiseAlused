namespace ForLoopInvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("endless for loop");


            ushort counter = 1;

            for (; ; )
            {
                Console.WriteLine(counter);
                counter++;

                if (counter > 10)
                {
                    Environment.Exit(1);
                }
            }
        }
    }
}
