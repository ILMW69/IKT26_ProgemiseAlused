namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //andmed meetrites
            double Dmünt = 0.02575;//mündi diameeter
            double Rmaa = 6371000;//Maa raadius

            double Pmaa = 2 * Math.PI * Rmaa;
            double müntideArv = Pmaa / Dmünt;

            Console.WriteLine($"Maa ümbermõõt on {Pmaa / 1000:0.##}km ja sinna mahub {müntideArv:0} münti");
        }
    }
}
