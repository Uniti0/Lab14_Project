using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] Sell_price = new int[4];
            Sell_price[0] = 100;
            Sell_price[1] = 80;
            Sell_price[2] = 60;
            Sell_price[3] = 120;

            double temp = 0;
            double temp1 = 0;

            for (int i = 0; i < 4; i++)
            {
                if (Sell_price[i] > temp ) 
                {
                    temp = Sell_price[i];
                    temp1 = i;
                }  

            }
            Console.WriteLine("Самый выгодный банк для продажи долларов " + temp1);
            Console.ReadKey();
        }
    }
}
