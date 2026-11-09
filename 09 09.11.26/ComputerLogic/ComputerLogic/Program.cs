namespace ComputerLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, kalkulatsioon!");

            double calculaion1 = 3 + 8 / (4 - 2) * 4;
            double calculaion2 = 3 + 8 / 4 - 2 * 4;
            double calculaion3 = (3 + 8) / (4 - 2) * 4;
            //kui tahad, et võtaks arvesse komakohad, siis pane nr lõppu .0
            double calculaion4 = (3.0 + 8.0) / (4.0 - 2.0) * 4.0;

            Console.WriteLine("3 + 8 / (4 - 2) * 4 = " + calculaion1);
            Console.WriteLine("3 + 8 / 4 - 2 * 4 = " + calculaion2);
            //annab vastuseks 20 aga peaks olema 22
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + calculaion3);
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + calculaion4);
        }
    }
}
