using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ondaliklari ayarimak icin ',' kullanin!");
            Console.WriteLine("Sayi giriniz");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sayi giriniz");

            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            

            Console.WriteLine("Yapilacak islemi seciniz!\n1-Toplam\n2-Cikarma\n3-Carpma\n4-Bolme");

            int operation =Convert.ToInt32(Console.ReadLine());

            switch (operation)

            {
                case 1:
                    result = num1 + num2;
                    break;

                case 2:
                    result = num1 - num2;
                    break;

                case 3:
                    result = num1 * num2;
                    break;

                case 4:
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine(result);

            Console.ReadLine();


        }
    }
}
