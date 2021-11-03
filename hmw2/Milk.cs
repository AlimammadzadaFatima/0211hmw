using System;
using System.Collections.Generic;
using System.Text;

namespace hmw2
{
    class Milk : Product
    {
        public Milk(double volume, double fatRate, string name, double price, int count/*, int totalInCome*/ ): base(name)
        {
            this.Volume = volume;
            this.FatRate = fatRate;
            this.Name = name;
            this.Price = price;
            this.Count = count;
            //this.TotalInCome = totalInCome;

        }
        double Volume;
        double FatRate;
        string Name;
        double Price;
        int Count;
        //int TotalInCome;
    }
}
