namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 10:
                    Console.WriteLine("su number on 10 dipshit");
                    break;

                case 20:
                    Console.WriteLine("su number on suurem kui 19 ja väiksem kui 21... dipshit");
                    break;

                case 30:
                    Console.WriteLine("su number on alla 31");
                    break;

                default:
                    Console.WriteLine("Sisestasid teise numbri: " + num);
                    break;
            }
        }
    }
}
