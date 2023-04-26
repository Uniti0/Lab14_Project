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
            int Kol_vo_BANKOV = banks.Length; //Размерность массива
            int[] Sell_price = new int[Kol_vo_BANKOV]; //Нью массив
            Random rnd = new Random(); 
            int Kyrs_Valyt = rnd.Next(59, 121); //Генератор случайных чисел
            int SamayaVisokayaCena = 0; 
            string LychshiyBankRossii = ""; 
            Console.WriteLine("Курсы валют: "); //Сообщение пользоваетлю
            Console.WriteLine();
            for (int i = 0; i < Kol_vo_BANKOV; i++) //Цикл Павла
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
            Console.Write("Введите сумму в долларах: "); //Сообщение пользователю
            double dollars = double.Parse(Console.ReadLine()); //Ввод кол-ва долларов
            double maxRubles = SamayaVisokayaCena * dollars; //Макс прибыль
            Console.WriteLine("Самый выгодный банк для продажи долларов: " + LychshiyBankRossii); //Вывод ответа
            Console.WriteLine("Cумма в рублях, которую можно получить за {0}$ = {1}", dollars, maxRubles); //Вывод ответа
            Console.ReadKey(); //Задержка экрана
        }
    }
}
