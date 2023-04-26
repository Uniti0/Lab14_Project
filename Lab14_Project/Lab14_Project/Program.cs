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
            string[] banks = { "Сбербанк", "ВТБ", "Газпромбанк", "Альфа-банк", "Тинькофф", "Росбанк", "Уралсиб", "Хоум Кредит", "Райффайзенбанк", "Промсвязьбанк" };
            int Kol_vo_BANKOV = banks.Length;

            int[] Sell_price = new int[Kol_vo_BANKOV];

            Random rnd = new Random();
            int Kyrs_Valyt = rnd.Next(59, 121);

            int SamayaVisokayaCena = 0;
            string LychshiyBankRossii = "";

            Console.WriteLine("Курсы валют:");
            Console.WriteLine();
            for (int i = 0; i < Kol_vo_BANKOV; i++)
            {
                double randomOtklonenie = rnd.NextDouble() * 0.2 - 0.1; // отклонение в 10%
                Sell_price[i] = (int)(Kyrs_Valyt * (1 + randomOtklonenie) * 100) / 100; // округляем до 2 знаков после запятой
                Console.WriteLine(banks[i] + ": " + "(" + Sell_price[i] + ")");
                if (Sell_price[i] > SamayaVisokayaCena)
                {
                    SamayaVisokayaCena = Sell_price[i];
                    LychshiyBankRossii = banks[i];
                }
            }

            Console.WriteLine();
            Console.Write("Введите сумму в долларах: ");
            double dollars = double.Parse(Console.ReadLine());
            double maxRubles = SamayaVisokayaCena * dollars;
            Console.WriteLine("Самый выгодный банк для продажи долларов: " + LychshiyBankRossii);
            Console.ReadLine();
            //Можно дописать покупку доллара, покупка есть
        }
    }
}
