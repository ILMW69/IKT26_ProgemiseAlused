namespace ForPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = num > 1 ;


            /*if (num % 2 == 0)
            {
                isPrime = false;
            }
            else
            {
                isPrime = true;
            }*/

            for (int i = 2; i * i <= num ; i++)
            {
                if (num% i == 0)
                {
                    isPrime = false;
                    break;
                }
            }


            if (isPrime)
            {
                Console.WriteLine("on algarv");
            }
            else
            {
                Console.WriteLine("ei ole algarv");
            }
        }
    }
}
