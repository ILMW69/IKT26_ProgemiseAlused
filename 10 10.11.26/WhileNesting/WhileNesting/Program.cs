namespace WhileNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int num = 1;
            while (num <= 5)
            {
                int num2 = 1;
                while (num2 <= 5)
                {
                    Console.Write(num2 + " ");
                    num2++;
                }
                Console.WriteLine();
                num++;
            }
        }
    }
}
