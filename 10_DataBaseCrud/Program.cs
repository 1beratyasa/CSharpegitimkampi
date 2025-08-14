using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DataBaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete

            Console.WriteLine("*****Menü sipariş işlem paneli*****");
            Console.WriteLine();
            #region kategori ekleme işlemi
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("eklemek istediğiniz kategori adı:");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection= new SqlConnection("Data Source=DESKTOP-VV8S24H\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();//koşulsuz sorguyu çalıştırır
            //connection.Close();

            //Console.WriteLine("kategori başarılı bir şekilde eklendi.");
            #endregion

            #region ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write(" ürün adı:");
            //productName = Console.ReadLine();
            //Console.Write("ürün fiyatı:");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VV8S24H\SQLEXPRESS\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand ("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("ürün eklendi.");


            #endregion

            #region Ürün Listeleme

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VV8S24H\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select*From TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);//köprü
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //    Console.WriteLine();
            //}


            //connection.Close();

            #endregion

            #region Ürün Silme
            //Console.Write("silinecek ürün ıd:");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VV8S24H\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();

            //Console.WriteLine("silme işlemi yapıldı.");

            //connection.Close();

            #endregion

            #region Ürün Güncelleme

            Console.Write("güncellenecek ürün ıd:");
            int productId = int.Parse(Console.ReadLine());


            Console.Write("güncellenecek ürün adı:");
            string productName = (Console.ReadLine());

            Console.Write("güncellenecek ürün fiyatı:");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VV8S24H\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId =@productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("güncelleme başarılı.");

            #endregion
            Console.Read();






        }
    }
}
