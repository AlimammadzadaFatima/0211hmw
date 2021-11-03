using System;

namespace hmw2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine($"Mehsulun adini daxil edin;");
            string name = Console.ReadLine();
            int count = GetInfoInt("count");
            double price = GetInfoDouble("price");
            double volume = GetInfoDouble("volume");
            double fatRate = GetInfoDouble("fat rate");
            Console.WriteLine("Sell metodunu bura getire bilmedim :(");
            //Milk milk = new Milk(volume, fatRate, name, price, count);

        }
        static int GetInfoInt(string info)
        {
            string infostr;
            int infoint;
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Mehsulun {info} daxil edin;");
                infostr = Console.ReadLine();
            } while (!int.TryParse(infostr, out infoint));
            return infoint;
        }
        static double GetInfoDouble(string info)
        {
            string infostr;
            double infodouble;
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Mehsulun {info} daxil edin;");
                infostr = Console.ReadLine();
            } while (!double.TryParse(infostr, out infodouble));
            return infodouble;
        }
    }
}
