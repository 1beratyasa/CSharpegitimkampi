using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;  
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.write("Şifre doğru"); 
            //}
            //else
            //{
            //    Console.write("Şifre yanlış");
            //}


            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital =="ankara" &   country == "türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi girdiniz");
            //}


            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.write("Sayı doğru");
            //}
            //else
            //{
            //    Console.write("Sayı hatalı");
            //}


            //int exam1, exam2, exam3, averange;
            //string result = " Hata! ";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //averange = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların ortalaması: " + averange);

            //if (averange >0 & averange  <=50)
            //{
            //    result =  " Sonuç vasat";

            //}
            //if (averange > 50 & averange <= 70)
            //{
            //    result =  " Sonuç orta";

            //}
            //if (averange > 70 & averange <= 84)
            //{
            //    result = " Sonuç iyi";

            //}
            //if (averange > 84 )
            //{
            //    result = " Sonuç çok iyi";

            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" || city =="malatya" || city == "diyarbakır" || city == "Sri lanka" )
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}


            //Console.WriteLine("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();

            //if(username  != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}
            #endregion

            #region  Mod İşlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            // int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine()); 

            //int result = number1 % number2; 

            //Console.Write("1.Sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number =int.Parse(Console.ReadLine());

            //if (number % 2 ==0)
            //{
            //    Console.Write("Sayı çifttir"); 
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}
            #endregion

            #region  Örnek Proje Uygulması



            //Console.WriteLine("***** C# Eğitim Kampı Resterasyonu *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();


            //string menüItem;
            //Console.Write("Detayını görmek istediğniz menü seçimi: ");
            //menüItem = Console.ReadLine();

            //if(menüItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------- Ana Yemkler -----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabğı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musaka ");
            //    Console.WriteLine("----------- Ana Yemkler -----------");

            //}

            //if (menüItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------- Çorbalar -----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezo Gelin Çorbası"); 
            //    Console.WriteLine("----------- Çorbalar  -----------");

            //}
            //if (menüItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------- Pizzalar -----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("----------- Pizzalar  -----------");

            //}
            //if (menüItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------- İçecekler -----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su ");
            //    Console.WriteLine("----------- İçecekler  -----------");

            //}
            //if (menüItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------- Tatlılar -----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("----------- atlılar  -----------");

            //}






            #endregion

            #region  Switch Case
            //Console.Write("Lütfen ay girişi yapınız: ");
            //int mounthNumber=int.Parse(Console.ReadLine());

            //switch (mounthNumber)       
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break; 
            //    case 3:Console.Write("Mart"); break;
            //    case 4:Console.Write("Nisan"); break;
            //    case 5:Console.Write("Mayıs"); break;
            //    case 6:Console.Write("Haziran"); break;
            //    case 7:Console.Write("Temmuz"); break;
            //    case 8:Console.Write("Ağustos"); break;
            //    case 9:Console.Write("Eylül"); break;
            //    case 10:Console.Write("Ekim"); break;
            //    case 11:Console.Write("Kasım"); break;
            //    case 12:Console.Write("Aralık"); break;
            //    default:Console.Write("Hatalı Veri Girişi"); break; 

            //}





            #endregion

            #region  Switch Case Hesap Makinası
            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayıyı giriniz: ");
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi seçin: ");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case'+':
            //    result = number1 + number2;
            //    Console.WriteLine("Toplam: " +result); break;

            //    case '-':
            //    result = number1 - number2;
            //    Console.WriteLine("Fark: " +result); break;

            //    case '*':
            //    result = number1 * number2;
            //    Console.WriteLine("Çarpım: " +result); break;

            //    case '/':
            //    result = number1 / number2;
            //    Console.WriteLine("Bölüm: " + result); break;


            //}



            #endregion




        }
    }
}
