using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //////Console.WriteLine("***** Yemek Kategorileri  *****");
            //////Console.WriteLine( );
            //////Console.WriteLine("1-Çorbalar");
            //////Console.WriteLine("2-Ana Yemekler");
            //////Console.WriteLine("3-Soğuk Başlangıçlar");
            //////Console.WriteLine("4-Salatalar");
            //////Console.WriteLine("5-Tatlılar");
            //////Console.WriteLine("6-İçecekler ");
            //////Console.WriteLine();
            //////Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region StringDeğişkenler
            //////string name;
            //////name = "Berat"; 
            //////Console.WriteLine(name);  
            //////string customerName;
            //////string customerSurname;
            //////string customerPhone;
            //////string customerEmail, district, city;
            ////// customerName = "Berat";
            ////// customerSurname = "Yaşa";
            ////// customerPhone = "+90 539 746 11 21";
            ////// customerEmail = "berat.yasa.2@icloud.com";
            ////// district = "Kayapınar";
            ////// city = "Amed";
            //////Console.WriteLine("**** Rezervasyon Kartı ****");
            //////Console.WriteLine();
            //////Console.WriteLine("---------------------------------------------------");
            //////Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //////Console.WriteLine("İletişim: " + customerPhone);
            //////Console.WriteLine("Email Adresi: " + customerEmail);
            //////Console.WriteLine("Adres: " + district + "/" + city);
            //////Console.WriteLine("---------------------------------------------------");
            //////Console.WriteLine();
            //////Console.WriteLine("---------------------------------------------------");  
            //////customerName = "İkra";
            //////Console.WriteLine(customerName);
            //////customerSurname = "Yaşa";
            //////customerPhone = "+90 552 752 40 44";
            //////customerEmail = "ikra.yasa.2@icloud.com";
            //////district = "Yeşilyurt";
            //////city = "Malatya";
            //////Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //////Console.WriteLine("İletişim: " + customerPhone);
            //////Console.WriteLine("Email Adresi: " + customerEmail);
            //////Console.WriteLine("Adres: " + district + "/" + city); 
            //////Console.WriteLine("---------------------------------------------------");

            #endregion

            #region Int Değişkenler
            //int 
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50; 
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restorant Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Ham burger: " + hamburgerPrice + "TL");
            Console.WriteLine("-----Kola: " + cokePrice + "TL");
            Console.WriteLine("-----Su: " + waterPrice + "TL");
            Console.WriteLine("-----Kızartmalar: " + friesPrice + "TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + "TL");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice; 

            
            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1 ;
            pizzaCount = 0;
            lemonadeCount = 0;
            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadePrice * lemonadePrice;
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Hamburger tutarı: " + totalHamburgerPrice + "Tl ");
            Console.WriteLine("Kola tutarı: " + totalCokePrice + " Tl ");
            Console.WriteLine("Su  tutarı: " + totalWaterPrice + " Tl ");
            Console.WriteLine("Kızartma tutarı: " + totalFriesPrice + " Tl ");
            Console.WriteLine("Pizza tutarı: " + totalPizzaPrice + " Tl ");
            Console.WriteLine("Limonata tutarı: " + totalLemonadePrice + " Tl ");

            Console.WriteLine();
            int totalPrice = totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice + totalHamburgerPrice;
            Console.WriteLine("Toplam ödenecek tutar: " + totalPrice + " Tl");

            








            #endregion
            Console.Read();
        }
    }
}

  