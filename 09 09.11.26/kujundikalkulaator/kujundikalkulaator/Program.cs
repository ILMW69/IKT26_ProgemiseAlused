namespace kujundikalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*Ruudu sees asub ring. Rinfi raadius on 3 ühikut.
             * Leia ja välista ekraanile ruudu pindala ja ümbermõõt.*/

            int raadius = 3;
            int külg = raadius * 2;
            int P = 4 * külg;
            int S = külg * külg;


            Console.WriteLine($"ümbermõõt on {P} ü, pindala on {S} ü");

            //a rvuta ringi pindala ja ümbermõõt
            double Pr = Math.Round(2 * Math.PI * raadius, 2, MidpointRounding.AwayFromZero);
            double Sr = Math.PI * Math.Pow(raadius, 2);

            Console.WriteLine($"ümbermõõt on {Pr} ü, pindala on {Sr:0.##} ü");
        }
    }
}
