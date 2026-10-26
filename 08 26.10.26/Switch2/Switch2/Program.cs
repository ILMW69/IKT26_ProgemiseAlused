namespace Switch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // olukord
            int random_number = new Random().Next(1, 4);

            Console.WriteLine("olukord: " + random_number);

            switch (random_number)
            {
                case 2:
                    Console.WriteLine("sisesta oma vanus");
                    int vanus = int.Parse(Console.ReadLine());
                    Console.WriteLine("su vanus on " + vanus);
                    break;

                case 3:
                    Miau();
                    break;

                default: // kui random_number on 1
                    Console.WriteLine("Korrutamine, sisesata esimene number");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("sisesta teine number");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("vastus on " + (num1 * num2));
                    break;
            }

            // print miau miau
            static void Miau()
            {
                Console.WriteLine("Miau!");
            }
        }
    }
}
