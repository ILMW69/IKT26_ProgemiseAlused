namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("sisesta number");

            int input = int.Parse(Console.ReadLine());
            string binary_output = "";

            while (input > 0)
            {
                int reminder = input % 2;
                binary_output = reminder + binary_output;
                input /= 2;
            }

            Console.WriteLine(binary_output);
        }
    }
}
