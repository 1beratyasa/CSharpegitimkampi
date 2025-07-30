using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Methoods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void   Metotlar
            //()
            //Geriye değer döndürmeyen metotlar
            //Customer--->listele-Ekle-Sil-Güncelle
            //Void

            //void customerList()
            //{
            //    Console.WriteLine("Berat Yaşa");
            //    Console.WriteLine("Ikra Yaşa");
            //    Console.WriteLine("Deniz Yaşa");
            //    Console.WriteLine("Aden Yaşa");
            //}
            //customerList();
            //customerList();
            //customerList();
            //customerList();

            //void sum()
            //{
            //    int x = 11;
            //    int y =22;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();



            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar 

            //void WhriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WhriteMethod("MEHMET YAŞA");


            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + "  " + surName);

            //}
            //CustomerCard("İkra", "Yaşa");
            //CustomerCard("Berat ", "Yaşa");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void sum(int number1, int number2, int number3)
            //{
            //     int result= number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //sum(13, 33, 45); 


            #endregion

            #region Geriye Değer Döndüren Metotlar

            string customerName()
            {
                return "berat yaşa";
            }
            customerName();
            // bu ekrana yazdırmaz  sadece değr olarak döner


            //string studenCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name + " " + surName;

            //}
            //Console.WriteLine(studenCard());



            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar

             string countryCard(string countryName,string capital, string flagColor)
            {
                string cardInfo= "Ülke: " + countryName + " -Başkent: " + capital + " Bayrak rengi: " + flagColor;
                return cardInfo;  
            }

            string x, y, z;
            Console.Write("Ülke adını giriniz: ");
            x = Console.ReadLine();

            Console.Write("Başkenti giriniz: ");
            y = Console.ReadLine();

            Console.Write("Bayrak rengini giriniz: ");
            z = Console.ReadLine();

            Console.WriteLine(countryCard(x,y,z));
            Console.WriteLine(countryCard("türkiye", "amed", "kırmızı yeşil") );


            #endregion
            Console.Read();
            
        }
    }
} 
