namespace SwitchMultipleCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple cases");

            string input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "Intro to C#" or "Variables" or "Data Types":
                    Console.WriteLine("basics");
                    break;

                case "OOP" or "Classes" or "Objects":
                    Console.WriteLine("intermediate");
                    break;

                case "Asynchronous Programming" or "LINQ" or "Delegates":
                    Console.WriteLine("Advances");
                    break;

                default:
                    Console.WriteLine("Unkown");
                    break;
            }
        }
    }
}
