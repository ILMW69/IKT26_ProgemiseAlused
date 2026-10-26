namespace WhileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Do");

            int num = int.Parse(Console.ReadLine());
            int i = 1;

            /*iteratsioon e tsükkel, mis kordub
             * nii kaua kui vastab tingimustele */
            do
            {
                Console.WriteLine(i);
                i++;
                Thread.Sleep(10);

            } while (i <= num);

        }
    }
}
