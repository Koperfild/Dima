using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие2
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a = 1;
            //double b = 6;
            //double c = 10;
            //double d = 15;
            //double i = 1.5;

            //double sum = a + b + c + d + i;
            //Console.WriteLine("Сумма чисел равна:");
            //Console.WriteLine(sum + "\n\n");

            //double srednee = sum / 5;

            //Console.WriteLine("Первое число: " + a + " " + "Среднее число: " + srednee);


            //if (a > srednee)
            //    Console.WriteLine("Первое число больше среднего");
            //else if (a < srednee)
            //    Console.WriteLine("Первое число меньше среднего");
            //else if (a == srednee)
            //    Console.WriteLine("Первое число равно среднему");
            //else
            //{

            //}


            //for (1; 2; 3)
            //{

            //}

            //int a;
            //a++;
            //a--
            //++a;
            //a = a + 1;
            //a += 5;
            //a = a + 5;
            //a /= 10;
            //a -= 10;
            //a += 10;



            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 1; i <= 10; i++)
            //{
            //    //if ((i % 2) == 1)
            //    //{
            //    //    continue;
            //    //}
            //    if (i == 6)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(" i равно " + i + "\n\n");

            //    for (int j = i - 1; j > 0; j--)
            //    {
            //        Console.WriteLine("\t" + j);
            //    }


            //    //if ((i % 2) == 0)
            //    //{
            //    //    Console.WriteLine(i);
            //    //}
            //}
            ////int k = 11;
            ////double peremennaya = Percents(k);

            ////Console.WriteLine(peremennaya);

            string stroka = "Summer time";
            int newlines = 10;
            int chisloProbelov = 5;

            Pechat(stroka, newlines, chisloProbelov);

            Pechat(stroka, newlines, 0);
            Pechat(stroka, 0, 0);
            Pechat(stroka);

            VesVodi(20);
            VesVodi(20, 200, 3, 144);

            Pechat(stroka, newlines);
            Pechat(stroka);

            Console.ReadKey();

            Console.Clear();

            Pechat("Другая строка", 20, 20);

            Console.WriteLine();
            Console.ReadKey();
        }
        private static double Percents(int a, int b, int c, double d, double e)
        {
            double result = a * 0.01;
            Console.WriteLine("Мы внутри метода");
            return result;
        }
        private static void Pechat(string s, int lines, int probeli)
        {
            for (int i = 0; i < lines; i++)
            {
                Console.Write("\n");
            }
            for (int i = 0; i < probeli; i++)
                Console.Write(" ");

            Console.WriteLine(s);
        }
        private static void Pechat(string s, int lines)
        {
            Pechat(s, lines, 0);
        }
        private static void Pechat(string s)
        {
            Pechat(s, 0, 0);
        }
        private static double VesVodi(double V, double temperatura, double yrovenSoli, double visotaNadYrovnemMorya)
        {
            Pechat("lalala");
            return V*temperatura*0.01*yrovenSoli/visotaNadYrovnemMorya * 1.0034;
        }
        private static double VesVodi(double V)
        {
            return 1;
        }

    }
    public class MyClass
    {

    }
}
