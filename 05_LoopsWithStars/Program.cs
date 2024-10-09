using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Alt Alta 10 tane yıldız oluşturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Yanyana 10 tane yıldız oluşturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region AltAlta 10 tane yıldız oluşturma her satırda 10 yıldız olsun
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j  = 0; j < 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //   Console.WriteLine();
            //}
            #endregion

            #region Dik üçgen
            //for (int i = 1; i <= 10; i++)
            //{
            //   for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //   Console.WriteLine();
            //}
            #endregion

            #region Ters Dik üçgen
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region üçgen
            //int height = 10; 

            //for (int i = 1; i <= height; i++)
            //{

            //    for (int j = 1; j <= height - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine(); 
            //}
            #endregion

            #region Dik ve Ters Dik üçgen beraber
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 9; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            #endregion

            #region Elmas
            //int height = 10;

            //for (int i = 1; i <= height; i++)
            //{

            //    for (int j = 1; j <= height - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}


            //for (int i = height-1; i >= 1; i--)
            //{

            //    for (int j = 1; j <= height - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            #endregion

            #region Baklava Dilimi
            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n-1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = n-1  ; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit

            //int n  = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    //Boşluk
            //    for (int j = n-i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //      //Yıldız
            //    for (int k = 1; k <= (2 * i) - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit

            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    //Boşluk
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldız
            //    for (int k = 1; k <= (2 * i) - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion




            Console.Read();
        }
    }
}
