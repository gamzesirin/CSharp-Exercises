using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CSharp_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables
            //double number;
            //number = 11.4;
            //Console.WriteLine("number: " + number);
            //double number1 = 10.5;
            //double number2 = 20.3;
            //double result = number1 + number2;
            //Console.WriteLine("The result is: " + result);
            //Console.ReadLine();

            //Console.WriteLine("---------Fiyat Listesi---------");
            //double orangePrice, applePrice, bananaPrice;
            //double tomato,patato, carrot;

            //orangePrice = 2.5;
            //applePrice = 3.5;
            //bananaPrice = 4.5;
            //tomato = 5.5;
            //patato = 6.5;
            //carrot = 7.5;

            //Console.WriteLine("Orange Unit Price: " + orangePrice + "TL");
            //Console.WriteLine("Apple Unit Price: " + applePrice + "TL");
            //Console.WriteLine("Banana Unit Price: " + bananaPrice + "TL");
            //Console.WriteLine("Tomato Unit Price: " + tomato + "TL");
            //Console.WriteLine("Patato Unit Price: " + patato + "TL");
            //Console.WriteLine("Carrot Unit Price: " + carrot + "TL");



            //double appleGram = 4.5345;
            //double orangeGram = 3.512;
            //double bananaGram = 2.1285;
            //double tomatoGram = 1.5;
            //double patatoGram = 2.320;
            //double carrotGram = 3.5;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double bananaTotalPrice = bananaPrice * bananaGram;
            //double tomatoTotalPrice = tomato * tomatoGram;
            //double patatoTotalPrice = patato * patatoGram;
            //double carrotTotalPrice = carrot * carrotGram;

            //Console.WriteLine("Apple Total Price: " + appleTotalPrice + "TL");
            //Console.WriteLine("Orange Total Price: " + orangeTotalPrice + "TL");
            //Console.WriteLine("Alınan ürün : Portakal: Birim fiyatı " + orangePrice + " gramajı " + orangeGram + " toplam tutarı : " + orangeTotalPrice + "TL");
            //Console.WriteLine("Alınan ürün : Elma: Birim fiyatı " + applePrice + " gramajı " + appleGram + " toplam tutarı : " + appleTotalPrice + "TL");

            //Console.WriteLine("Banana Total Price: " + bananaTotalPrice + "TL");
            //Console.WriteLine("Tomato Total Price: " + tomatoTotalPrice + "TL");

            //Console.WriteLine("Patato Total Price: " + patatoTotalPrice + "TL");
            //Console.WriteLine("Carrot Total Price: " + carrotTotalPrice + "TL");
            //Console.WriteLine("Total Price: " + (appleTotalPrice + orangeTotalPrice + bananaTotalPrice + tomatoTotalPrice + patatoTotalPrice + carrotTotalPrice) + "TL");
            //Console.ReadLine();
            #endregion

            #region
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("₺");
            //Console.ReadLine();
            #endregion


            #region Char Variables
            //char character = 'A';
            //Console.WriteLine("character: " + character);
            //char character1 = 'B';
            //char character2 = 'C';
            //Console.WriteLine("character1: " + character1);
            //Console.ReadLine();
            #endregion

            #region Klavyeden veri girişi almak
            //Console.WriteLine("Lütfen bir sayı giriniz: ");
            //string numberString = Console.ReadLine();
            //int numberInt = Convert.ToInt32(numberString);
            //Console.WriteLine("Girilen sayı: " + numberInt);
            //Console.ReadLine();
            #endregion

            #region Klavyeden veri girişi almak
            //string passengerName, passengerSurname, passengerAge , passengerIdentityNumber , passengerDistrict , passengerCity;
            //Console.Write("Lütfen Adınızı Giriniz: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Lütfen Soyadınızı Giriniz: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Lütfen Yaşınızı Giriniz: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Lütfen Kimlik Numaranızı Giriniz: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.Write("Lütfen İlçenizi Giriniz: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Lütfen Şehrinizi Giriniz: ");
            //passengerCity = Console.ReadLine();
            //Console.WriteLine("Yolcu Adı: " + passengerName + " Soyadı : "+ passengerSurname);
            //Console.ReadLine();
            #endregion

            #region Klavyeden tam sayı girişleri ve dönüşümleri

            //int shoesPrice, tvPrice, laptopPrice;
            //int shoesCount, tvCount, laptopCount;
            //int shoesTotalPrice, tvTotalPrice, laptopTotalPrice;
            //int totalPrice;
            //int totalCount;
            //shoesPrice = 1000;
            //tvPrice = 2000;
            //laptopPrice = 3000;

            //Console.Write("Ayakkabı Adedini Giriniz: ");
            //shoesCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("TV Adedini Giriniz: ");
            //tvCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Laptop Adedini Giriniz: ");
            //laptopCount = Int16.Parse(Console.ReadLine());

            //shoesTotalPrice = shoesPrice * shoesCount;
            //tvTotalPrice = tvPrice * tvCount;
            //laptopTotalPrice = laptopPrice * laptopCount;

            //totalPrice = shoesTotalPrice + tvTotalPrice + laptopTotalPrice;
            //totalCount = shoesCount + tvCount + laptopCount;

            //Console.WriteLine("Ayakkabı Toplam Fiyatı: " + shoesTotalPrice + "TL");
            //Console.WriteLine("TV Toplam Fiyatı: " + tvTotalPrice + "TL");
            //Console.WriteLine("Laptop Toplam Fiyatı: " + laptopTotalPrice + "TL");

            //Console.WriteLine("Toplam Ödemeniz Gereken Fiyat: " + totalPrice + "TL");
            //Console.WriteLine("Toplam Adet: " + totalCount);
            //Console.ReadLine();

            #endregion

            #region Klavyeden ondalıklı sayı girişleri ve dönüşümleri
            //double exam1, exam2, exam3;
            //double average;
            //Console.Write("1. Sınav Notunuzu Giriniz: ");
            //exam1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("2. Sınav Notunuzu Giriniz: ");
            //exam2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("3. Sınav Notunuzu Giriniz: ");
            //exam3 = Double.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav Ortamanız :  " + average);
            //Console.ReadLine();
            #endregion

            #region Klavyeden karakter girişleri
            //char gender;
            //Console.Write("Cinsiyetinizi Giriniz: ");
            //gender =char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet :" + gender);
            //Console.ReadLine();
            #endregion

        }
    }
}
