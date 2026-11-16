namespace korrutusTabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korrutustabel");

            int num = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    if (j <= num -i)
                    {
                        Console.Write($"{j}*{i}={j * i}, ");
                    }
                    else
                    {
                        Console.Write($"{j}*{i}={j * i}, ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
