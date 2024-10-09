using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CSharp_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for loop
            //for(x;y;z)
            //x: başlangıç
            //y: bitiş
            //z: artış-azalış

            //int i;

            //for (i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int j;
            //for (j = 10; j >= 0; j--)
            //{
            //    Console.WriteLine(j);
            //}

            //for (int k = 0; k <= 10; k++)
            //{
            //    Console.WriteLine("C sharp eğitim örnekleri");
            //}

            //for (int l = 0; l <= 10; l++)
            //{
            //    Console.WriteLine("C sharp eğitim örnekleri");
            //    if (l == 5)
            //    {
            //        break;
            //    }
            //}

            //for (int m = 0; m <= 10; m++)
            //{
            //    if (m == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(m);

            //}


            //for (int i = 0; i <= 30; i+=3)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 30; i >=0; i -= 2)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine("Lütfen ekrana yazılmasını istediğiniz sayı adedini giriniz");

            //int finishValue = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasınnnn");
            //}


            //for(int m=0; m < 10; m++)
            //{
            //    if(m%4==0) {
            //        Console.WriteLine(m);
            //    }

            //}

            //int totalValue = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine("Toplam Değer: " + totalValue);


            //int totalValue = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("Toplam Değer: " + totalValue);

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("1 den 50 ye kadar 7'ye bölünen sayı adedi: " + count);

            //int bacterium = 1;

            //for(int i=1; i<=24; i++ )
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saatteki bakteri sayısı: " + bacterium);
            //}
            //Console.Read();

            #endregion

            #region while loop

            //while (şart)
            //{
            //    işlemler
            //}

            //int i = 1;
            //while (i<20)
            //{
            //    Console.WriteLine("selam");
            //    i++;
            //}

            //int i = 1;
            //while(i<=10)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int k = 1;
            //int sum = 0;
            //while (k <=10)
            //{
            //    sum+= k;
            //    k++;
            //}
            //Console.WriteLine("Toplam Değer: " + sum);

            //Console.Read();
            #endregion


            #region ÖRNEK
            //KLAVYEDEN GİRİLEN 3 BASAMAKLI SAYININ BASAMAKLARI TOPLAMINI BULAN PROGRAM
            //int number, digit1, digit2, digit3, total;
            //Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz");
            //number = Convert.ToInt32(Console.ReadLine());
            //digit1 = number % 10;
            //number = number / 10;
            //digit2 = number % 10;
            //number = number / 10;
            //digit3 = number % 10;
            //total = digit1 + digit2 + digit3;
            //Console.WriteLine("Basamaklar toplamı: " + total);


            //int number, digit1=0, digit2=0, digit3=0, total;
            //Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz");
            //number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < 3; i++)
            //{
            //    if (i == 0)
            //    {
            //        digit1 = number % 10;
            //    }
            //    else if (i == 1)
            //    {
            //        digit2 = number % 10;
            //    }
            //    else
            //    {
            //        digit3 = number % 10;
            //    }
            //    number = number / 10;
            //}
            //total = digit1 + digit2 + digit3;
            //Console.WriteLine("Basamaklar toplamı: " + total);




            //Console.Read();
            #endregion
        }
    }
}
