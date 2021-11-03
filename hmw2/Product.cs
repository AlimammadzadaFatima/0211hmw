using System;
using System.Collections.Generic;
using System.Text;

namespace hmw2
{
    class Product
    {
        public Product(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get { return Name; }
            set
            {
                if (value.Length >= 3 && value.Length <= 25)
                    value = Name;
            }

        }
        public double Price
        {
            get { return Price; }
            set { if (value > 0) value = Price; }
        }
        public int Count { get; private set; }
        public double TotalInCome { get; private set; }
        double totalInCome = 0;

        public double Sell(int count, double price, int satilan)
        {
            if (count == 0)
                return 0;
            else
            {
                count = count - satilan;
                totalInCome = (satilan * price);
            }
            return totalInCome;
            return count;
        }

    }
}
