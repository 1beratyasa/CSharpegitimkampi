using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2.4.6.8
            //sarı,kırmızı,yeşil,mavi,
            //adana,ankara,amed,
            //DeğişkenTürü [] DiziAdı =new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[2]); 

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 734;
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Amed" };
            //Console.WriteLine(cities[4]);









            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            // string[] colors = { "sarı", "kırmızı", "mavi", "yeşil", "pembe", "mor" };
            //for (int i = 0; i < colors.Length; i++)
            // {
            //     Console.WriteLine(colors[i]);
            // }

            //int[] numbers = { 12, 21, 33, 42, 51, 67, 71, 81 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myArray = { 47, 85, 95, 41, 134, 456 };
            //int maxNumber = myArray[0];
            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //} 
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);//


            //int[] number = { 12, 21, 9, 56, 98, 123 };
            //Array.Sort(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine  (number[i]);
            //}


            //int[] number = { 12, 21, 9, 56, 98, 123 };
            //Array.Reverse(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}


            #endregion

            #region Dizi Metodları

            //string[] customers = { "ali", "berat", "samet" };
            //int index = Array.IndexOf(customers, "berat");
            //Console.WriteLine(index);


            //int[] numbers = { 12, 122, 213, 234, 54, 678, 9, 7 };
            //Console.WriteLine("Dizinin en büyük elemanı: "  + numbers.Max() + "  Dizinin en küçük elemanı:  " + numbers.Min());


            #endregion

            #region Kullanıcıdan Değer Alma


            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.WriteLine($"Lütfen {i+1}.Şehri giriniz: ");
            //    cities[i] = Console.ReadLine(); 
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //for (int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50, 60 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 123, 222, 1232, 421, 512, 600, 722, 813, 912,0 };
            //Console.WriteLine("Çift Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0 )
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("---------------");
            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i ] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}







            #endregion



            Console.Read();  
        }
    }
}
