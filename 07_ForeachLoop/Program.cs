using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //1:Değişken Türü
            //2:Değişkenin Adı
            //3:In
            //4:Liste,Koleksiyon,Dizi 

            //string[] cities = { "Milano", "Venedik", "Portofino", "Amalfi", "Varşova", "Budapeşt" };

            //foreach (string X in cities)
            //{
            //    Console.WriteLine(X);
            //}

            //int[] numbers = { 45, 67, 13, 245, 235, 68, 567, 56 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);  
            //}

            //int[] numbers = { 45, 67, 13, 245, 235, 68, 567, 56 };
            //foreach (int number in numbers)
            //{
            //    if (number%2 == 0) 
            //  { 
            //        Console.WriteLine(number);
            //  }

            //}

            //int[] numbers = { 45, 67, 13, 245, 235, 68, 567, 56 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);  

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number); 
            //}


            //string  word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            //// Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var: ");
            //int studentCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            //// Öğrenci isimlerini ve not  ortalamalarını saklayacak diziler     
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg =new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i+1}. öğrencinini ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();
            //    double totalExamResult = 0;
 
            //    //Her öğrenci için 3 sınav notu girişi
            //     for (int j = 0; j <3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli  öğrencinin {j+1}.sınav notunu giriniz: ");
            //          double value=double.Parse(Console.ReadLine());
            //        totalExamResult += value;//Notları topluyoruz.  
            //    }
            //    Console.WriteLine();  
            //     studentExamAvg[i] = totalExamResult/3;
                 
            //}
            ////Sınav Ortalamaları
            //for (int i = 0;i < studentCount; i++)
            //{
            //    Console.WriteLine("-----------------------------") ;

            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortlaması: {studentExamAvg[i]}");
           
            //// Öğrencilerin ortalaması veeçip kalma durumları

            //if (studentExamAvg[i] >=50)
            //{
            //    Console.WriteLine($"{studentNames[i]}  adlı öğrenci dersi geçti");
            //}
            //else
            //{
            //    Console.WriteLine($"{studentNames[i]}  adlı öğrenci dersten kaldı");
            //}

            //    Console.WriteLine("-----------------------------");


            //}









            #endregion
            Console.Read();
        }
    }
}
