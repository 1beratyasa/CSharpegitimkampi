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
            #region Alt ALta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("* ");
            //}



            #endregion

            #region Yan Yanyana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*  ");
            //}



            #endregion

            #region Alt ALta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********  ");
            //}



            #endregion

            #region Dik Üçgen

            //for (int i = 1; i <= 5; i++)
            //    {
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write  ("*");
            //    }
            //    Console.WriteLine();
            //}




            #endregion

            #region  Ters Dik Üçgen

            //for (int i = 5; i>=1 ; i--)
            //{
            //    for (int j = 1; j <= i;  j++)
            //    {
            //        Console.Write("*"); 
            //    }
            //    Console.WriteLine();
            //}




            #endregion

            #region  Dik Ve Ters Dik Üçgen beraber 

            //for (int i = 1; i<=5 ; i++ )
            // {
            //    for (int j = 1; j <= i;  j++)
            //    {
            //        Console.Write("*"); 
            //     }
            //    Console.WriteLine();
            //}
            // for (int i = 4; i >= 1; i--  )
            // {
            //     for (int j = 1; j <= i; j++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();
            // }  





            #endregion

            #region  Piramit

            int n = 5;
            for (int i = 0; i < n; i++)
            {
               for (int j = n-1; j > 0; j--)
                {
                    Console.Write(" ");
                }
            }




            #endregion



        }
    }
}
