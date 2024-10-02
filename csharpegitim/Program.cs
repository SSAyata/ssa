using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpegitim // 2_değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // doubledegiskenler();
           // chardegiskenler();
        }

        static void doubledegiskenler()
        {

            Console.WriteLine("*** Fiyat Listesi ***");

            double applePrice, orangePrice, stawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 17.02;
            orangePrice = 20.34;
            stawberryPrice = 22.11;
            potatoPrice = 18.03;
            tomatoPrice = 16.66;

            Console.WriteLine("---- Elma Birim Fiyatı :" + applePrice + " TL");
            Console.WriteLine("---- Portakal Birim Fiyatı :" + orangePrice + " TL");
            Console.WriteLine("---- Çilek Birim Fiyatı :" + stawberryPrice + " TL");
            Console.WriteLine("---- Patates Birim Fiyatı :" + potatoPrice + " TL");
            Console.WriteLine("---- Domates Birim Fiyatı :" + tomatoPrice + " TL");

            double appleGram, orangeGram, stawberryGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            stawberryGram = 0.700;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double stawberryTotalPrice = stawberryGram * stawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("Alınan Ürün : Elma - Birim Fiyat : " + applePrice + " - Toplam Gram : " + appleGram + " Toplam Tutar : " + appleTotalPrice + " TL");
            Console.WriteLine("Alınan Ürün : Portakal - Birim Fiyat : " + orangePrice + " - Toplam Gram : " + orangeGram + " Toplam Tutar : " + orangeTotalPrice + " TL");
            Console.WriteLine("Alınan Ürün : Çilek - Birim Fiyat : " + stawberryPrice + " - Toplam Gram : " + stawberryGram + " Toplam Tutar : " + stawberryTotalPrice + " TL");
            Console.WriteLine("Alınan Ürün : Patates - Birim Fiyat : " + potatoPrice + " - Toplam Gram : " + potatoGram + " Toplam Tutar : " + potatoTotalPrice + " TL");
            Console.WriteLine("Alınan Ürün : Domates - Birim Fiyat : " + tomatoPrice + " - Toplam Gram : " + tomatoGram + " Toplam Tutar : " + tomatoTotalPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + stawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine(shoppingTotalPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.ReadLine();
        }

        static void chardegiskenler()
        {
            #region
            char gender;
            Console.Write("Lütfen Cinsiyet Seçiniz: ");
            gender = char.Parse(Console.ReadLine());
            Console.Write("Seçtiğiniz Cinsiyet :"+gender);
            #endregion





            Console.Read();
        }
    }
}
