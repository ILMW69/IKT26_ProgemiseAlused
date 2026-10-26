namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Do Triangle");

            int lõpp = int.Parse(Console.ReadLine());

            int rida = 1;
            int num = 1;


            do
            {
                int veerg = 1;

                do
                {
                    Console.Write(num + " ");

                    num++;
                    veerg++;

                } while (veerg <= rida);

                Console.WriteLine("");// uus rida
                rida++;

                // reset num
                num = 1;

            } while (rida <= lõpp);
        }
    }
}
