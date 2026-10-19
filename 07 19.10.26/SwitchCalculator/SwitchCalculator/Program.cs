namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta esimene number");
            float input1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Vali tehe: *, /, +, -");
            string input_tehe = Console.ReadLine();


            Console.WriteLine("sisesta teine number");

            float input2 = float.Parse(Console.ReadLine());

            switch (input_tehe)
            {
                case "*":
                    Console.WriteLine($"vastus on {input1 * input2}");
                    break;

                case "/":
                    Console.WriteLine($"vastus on {input1 / input2}");
                    break;

                case "+":
                    Console.WriteLine($"vastus on {input1 + input2}");
                    break;

                case "-":
                    Console.WriteLine($"vastus on {input1 - input2}");
                    break;

                default:
                    break;
            }
        }
    }
}
