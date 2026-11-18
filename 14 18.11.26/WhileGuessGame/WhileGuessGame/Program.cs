namespace WhileGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int guess = int.Parse(Console.ReadLine());
            int attempts = 1;
            
            while (secretNumber != guess)
            {
                Console.WriteLine($"Vale arvamus, see on su proov nr. {attempts}");
                if (guess > secretNumber)
                {
                    Console.WriteLine("salanumber on väiksem");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("salanumber on suurem");
                }
                guess = int.Parse(Console.ReadLine());
                attempts++;
            }
            Console.WriteLine("õige");
        }
    }
}