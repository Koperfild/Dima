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
            int a;
            a = 5;

            double[] massiv;
            massiv = new double[100];

            for (int i=0; i<100 ;i++)
            {
                if (i == 0)
                    massiv[i] = 1;
                else
                    massiv[i] = massiv[i-1] * i;
            }
            for (int i=0; i<100;i++)
            {
                Console.WriteLine(massiv[i]);
            }
            Console.ReadKey();

            string[] massivStrok;
            massivStrok = new string[20];
            massivStrok[0] = "0-ая строка";
            massivStrok[8] = "8-ая строка";

            for (int i=0; i < 20;i++)
                Console.WriteLine(massivStrok[i]);

            double b = 2 * 2 * 2 * 2 * 2;
            //Math m = new Math();
            b = Math.Pow(2, 20);

            b = MyClass.Method1(3, 7);

            double[] massiv2 = new double[20];
            massiv2[11] = 100;
            massiv2[3] = 8;
            double sredneearifm;
            b = MyClass.SredneeArifmeticheskoe(massiv2);
        }
    }

    public static class MyClass
    {
        public static double Method1(double a, double b)
        {
            double result = a;
            for (int i=0; i < b -1 ; i++)
            {
                result = result * a;
            }
            return result;
        }
        public static double SredneeArifmeticheskoe(double[] chisla)
        {
            double result = 0;
            for (int i=0; i < chisla.Length;i++)
            {
                result = result + chisla[i];
            }
            result = result / chisla.Length;
            return result;
        }
    }

}
