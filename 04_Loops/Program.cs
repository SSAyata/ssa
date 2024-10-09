using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüler

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılması istediğiniz adedi giriniz : ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile karar yapıları


            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0) { Console.WriteLine(i); }
            //}

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0) { totalValue += i; Console.WriteLine(i); }
            //}

            //Console.WriteLine("---------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i <= 50; i++) { if (i % 7 == 0) { count++; } }
            //Console.WriteLine(count);


            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saat sonunda : " + bacterium);
            //}

            #endregion

            #region While Döngüsü

            //int i = 1;
            //while (i<=10) { Console.WriteLine("Merhaba döngüler"); i++; }

            //int i = 1;
            //while (i <= 10) { if (i % 3 == 0) { Console.WriteLine(i); } i++; }

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum+=i;
            //    i++;
            //}
            //Console.WriteLine(sum);





            #endregion

            #region Örnek Sınav Sorusu

            // Klavyeden girilen 3 basamaklı sayının basamakları toplanı hesaplayan kodu yazınız
            // 456

            // 3 Basamak Kontrollü 

            Console.WriteLine("3 Basamaklı Sayıyı Giriniz");
            int number = int.Parse(Console.ReadLine());
            while (number<100 | number > 999) { Console.WriteLine("3 Basamaklı Sayı Giriniz!"); number = int.Parse(Console.ReadLine()); }
           
            int ones, tens, hundreds;
            int sum;
            ones = number % 10 ;
            hundreds = number / 100;
            tens = (number % 100) / 10;

            sum = ones + tens + hundreds;

            Console.WriteLine("Basamakları Toplamı : " + sum);



            #endregion
            Console.Read();
        }
    }
}
