namespace YesGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "";

            while (word != "yes")
            {
                Console.WriteLine("Sisesta õige sõna");

                word = Console.ReadLine();
            }
            Console.WriteLine("õige!!!");
        }
    }
}
