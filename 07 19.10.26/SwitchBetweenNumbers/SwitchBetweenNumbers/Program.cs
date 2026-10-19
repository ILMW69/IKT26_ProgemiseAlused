namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("vahemikus 0 - 100");
                    break;

                case >= 101 and <= 200:
                    Console.WriteLine("vahemikus 101 - 200");
                    break;

                case >= 201 and <= 300:
                    Console.WriteLine("vahemikus 201 - 300");
                    break;

                default:
                    Console.WriteLine("number ei kuulu nendesse va");
                    break;
            }
        }
    }
}
