using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CSharpMainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is the first C# program");
            Console.WriteLine("********Yemek Kategorileri*******");
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Tatlılar");
            Console.WriteLine("4-Çıkış");
            Console.WriteLine("**********************************");
            Console.WriteLine("Lütfen bir seçim yapınız:");


            #endregion


            #region Değişkenler
            string secim = Console.ReadLine();

            string name = "Ali";
            string surname = "Veli";
            string fullName = name + " " + surname;
            Console.WriteLine(fullName);

            string customerName = "Melis";
            string customerSurname = "İştek";
            string customerFullName = customerName + " " + customerSurname;
            string city = "Amasya";
            string address = "Kızılay Mahallesi";
            string phone;
            string email;

            phone = "0532 123 45 67";
            email = "deneme@gmail.com";

            Console.WriteLine("********Rezervasyon Bilgileri*******");
            Console.WriteLine("Müşteri Bilgileri: " + customerFullName + " " + phone + " " + email);

            #endregion

            Console.WriteLine(customerName);
            customerName = "Ayşe";
            Console.Write(customerName);


            int number1 = 10;
            int number2 = 20;
            int result = number1 + number2;
            Console.WriteLine(result);

            Console.WriteLine("********Restorant Menü Bilgileri*******");

            int hamburgerPrice = 200;
            int colaPrice = 50;
            int friesPrice = 100;
            int totalPrice = hamburgerPrice + colaPrice + friesPrice;
            Console.WriteLine(totalPrice);
            Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("Cola: " + colaPrice + " TL");
            Console.WriteLine("Patates: " + friesPrice + " TL");
            Console.WriteLine("Toplam: " + totalPrice + " TL");


            int hamburgerCount = 2;
            int colaCount = 3;
            int friesCount = 1;
            int totalProductCount = hamburgerCount + colaCount + friesCount;
            Console.WriteLine("Toplam Ürün Adedi: " + totalProductCount);

            int totalHambugerPrice = hamburgerPrice * hamburgerCount;
            int totalColaPrice = colaPrice * colaCount;
            int totalFriesPrice = friesPrice * friesCount;

            int totalProductPrice = totalHambugerPrice + totalColaPrice + totalFriesPrice;
            Console.WriteLine("Toplam Ürün Fiyatı: " + totalProductPrice + " TL");


            Console.Read();
        }
    }
}
