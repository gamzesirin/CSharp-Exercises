using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CSharp_making_Decision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            Console.Write("Lütfen şifreyi giriniz: ");
            string password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Girilen şifre doğru");
            }
            else
            {
                Console.WriteLine("Girilen şifre yanlış");
            }
            Console.Read();


            string capital, country;
            Console.Write("Başkenti öğrenmek istediğiniz ülkenin adını giriniz: ");
            country = Console.ReadLine();
            if (country == "Türkiye")
            {
                capital = "Ankara";
            }
            else if (country == "ABD")
            {
                capital = "Washington";
            }
            else if (country == "Fransa")
            {
                capital = "Paris";
            }
            else if (country == "Almanya")
            {
                capital = "Berlin";
            }
            else
            {
                capital = "Bilinmiyor";
            }
            Console.WriteLine("Girdiğiniz ülkenin başkenti: " + capital);
            Console.Read();


            int number;
            Console.Write("Lütfen bir sayı giriniz: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Girilen sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girilen sayı tektir.");
            }
            Console.Read();


            int exam1, exam2, exam3, average;
            string result = "";
            Console.Write("1. Sınav Notunuzu Giriniz: ");
            exam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sınav Notunuzu Giriniz: ");
            exam2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Sınav Notunuzu Giriniz: ");
            exam3 = Convert.ToInt32(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;

            if (average >= 50)
            {
                result = "Geçti";
            }
            else
            {
                result = "Kaldı";
            }
            Console.WriteLine("Sınav Ortalamanız: " + average);
            Console.WriteLine("Durumunuz: " + result);
            Console.Read();



            #endregion

            #region Mod İşlemleri
            int numberr;
            numberr = 26;
            int resultt = numberr % 5;
            Console.WriteLine("26 sayısının 5'e bölümünden kalan: " + resultt);
            Console.Read();


            int number1, number2;
            Console.Write("1. Sayıyı Giriniz: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            int result1 = number1 % number2;
            Console.WriteLine(number1 + " sayısının " + number2 + " sayısına bölümünden kalan: " + result1);
            Console.Read();


            char team;
            Console.Write("Lütfen bir takım adının baş harfini giriniz: ");
            team = Convert.ToChar(Console.ReadLine());
            if (team == 'G' || team == 'g')
            {
                Console.WriteLine("Galatasaray");
            }
            else if (team == 'F' || team == 'f')
            {
                Console.WriteLine("Fenerbahçe");
            }
            else if (team == 'B' || team == 'b')
            {
                Console.WriteLine("Beşiktaş");
            }
            else if (team == 'T' || team == 't')
            {
                Console.WriteLine("Trabzonspor");
            }
            else
            {
                Console.WriteLine("Bilinmiyor");
            }
            Console.Read();

            #endregion

            #region Uygulama

            Console.WriteLine("--------- Restaurant Menüsü -----------");
            Console.WriteLine("1. Ana Yemekler");
            Console.WriteLine("2. İçecekler");
            Console.WriteLine("3. Tatlılar");
            Console.WriteLine("4. Ara Sıcaklar");
            Console.WriteLine("5. Çorbalar");


            string menuItem;

            Console.Write("Detayını görmek istediğiniz menüyü seçin:  ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine("------- Ana Yemekler --------");
                Console.WriteLine("1. Köri Soslu Tavuk");
                Console.WriteLine("2. Kızartma Tabağı");
                Console.WriteLine("3. Karışık Izgara");
            }
            else if (menuItem == "2")
            {
                Console.WriteLine("------- İçecekler --------");
                Console.WriteLine("1. Kola");
                Console.WriteLine("2. Fanta");
                Console.WriteLine("3. Limonata");
            }
            else if (menuItem == "3")
            {
                Console.WriteLine("------- Tatlılar --------");
                Console.WriteLine("1. Sütlaç");
                Console.WriteLine("2. Kadayıf");
                Console.WriteLine("3. Baklava");
            }
            else if (menuItem == "4")
            {
                Console.WriteLine("-------  Ara Sıcaklar --------");
                Console.WriteLine("1. Meze");
                Console.WriteLine("2. Salata");
                Console.WriteLine("3. Turşu");
            }
            else if (menuItem == "5")
            {
                Console.WriteLine("-------  Çorbalar --------");
                Console.WriteLine("1. Ezogelin");
                Console.WriteLine("2. Mercimek");
                Console.WriteLine("3. Yayla");
            }
            Console.Read();
            #endregion

            #region Switch Case
            int mounth;
            Console.WriteLine("Lütfen doğduğunuz ayı girin");
            mounth = int.Parse(Console.ReadLine());

            switch (mounth)
            {
                default:
                    Console.WriteLine("hatalı giriş yaptınız");
                    break;
                case 1:
                    Console.WriteLine("ocak");
                    break;
                case 2:
                    Console.WriteLine("şubat");
                    break;
                case 3:
                    Console.WriteLine("mart");
                    break;
                case 4:
                    Console.WriteLine("nisan");
                    break;
                case 5:
                    Console.WriteLine("mayıs");
                    break;
                case 6:
                    Console.WriteLine("haziran");
                    break;
                case 7:
                    Console.WriteLine("temmuz");
                    break;
                case 8:
                    Console.WriteLine("ağustos");
                    break;
                case 9:
                    Console.WriteLine("eylül");
                    break;
                case 10:
                    Console.WriteLine("ekim");
                    break;
                case 11:
                    Console.WriteLine("kasım");
                    break;
                case 12:
                    Console.WriteLine("aralık");
                    break;

            }
            Console.Read();

            #endregion

            #region Uygulama2

            int number01, number02, result0;
            char symbol;

            Console.WriteLine("Birinci sayıyı giriniz : ");
            number01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz : ");
            number02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz");
            symbol = Convert.ToChar(Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    result0 = number01 + number02;
                    Console.WriteLine(result0);
                    break;

                case '-':
                    result0 = number01 - number02;
                    Console.WriteLine(result);
                    break;

                case '*':
                    result0 = number01 * number02;
                    Console.WriteLine(result);
                    break;

                case '/':
                    result0 = number01 / number02;
                    Console.WriteLine(result);
                    break;
            }
            Console.Read();
            #endregion

        }
    }
}
