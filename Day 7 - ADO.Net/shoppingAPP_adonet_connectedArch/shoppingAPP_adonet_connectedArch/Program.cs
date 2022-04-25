using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace shoppingAPP_adonet_connectedArch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SqlConnection conn = new SqlConnection("server=p2project.database.windows.net;database=shoppingDB;integrated security=true")

            SqlConnection conn = new SqlConnection("Server=tcp:p2project.database.windows.net,1433;Initial Catalog=shoppingDB;Persist Security Info=False;User ID=project2;Password=Password@4567;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            #region Read data
            //Console.WriteLine("Enter Product No");
            //int pNo = Convert.ToInt32(Console.ReadLine());

            //SqlCommand cmd = new SqlCommand("select * from products where pid=@pno", conn);
            //cmd.Parameters.AddWithValue("@pno", pNo);

            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();

            //if (dr.Read())
            //{
            //    Console.WriteLine("Product Id : " + dr[0]);
            //    Console.WriteLine("Product Name : " + dr[1]);
            //    Console.WriteLine("Product Category : " + dr[2]);
            //    Console.WriteLine("Price : " + dr[3]);
            //    Console.WriteLine("Product Is In Stock : " + dr[4]);

            //}
            //else
            //{
            //    Console.WriteLine("Product Not Found");
            //}

            //dr.Close();
            //conn.Close();



            #endregion

            #region Add - Insert 
            //Console.WriteLine("Enter New Product Id");
            //int productId = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Product Name");
            //string pName = Console.ReadLine();
            //Console.WriteLine("Enter Product Category");
            //string pCategory = Console.ReadLine();
            //Console.WriteLine("Enter Product Price");
            //int pPrice = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Product Is It In Stock");
            //bool pIsInStock = Convert.ToBoolean(Console.ReadLine());

            //                                                                //this are called as SQL Query parameter
            //SqlCommand cmd = new SqlCommand("insert into products values(@Pid,@pname,@pCategory,@pPrice,@pIsInStock)",conn);
            //cmd.Parameters.AddWithValue("@Pid", productId); //this is called as Parameter Mapping
            //cmd.Parameters.AddWithValue("@pname", pName);
            //cmd.Parameters.AddWithValue("@pCategory", pCategory);
            //cmd.Parameters.AddWithValue("@pPrice", pPrice);
            //cmd.Parameters.AddWithValue("@pIsInStock", pIsInStock);


            //conn.Open();

            //int result = cmd.ExecuteNonQuery();

            //conn.Close();

            //Console.WriteLine("Product Added To System");
            #endregion

            #region Delete

          //  SqlCommand cmd = new SqlCommand("delete from products where pid=@pno", conn);
          //  Console.WriteLine("Enter Product No");
          //  int pNo = Convert.ToInt32(Console.ReadLine());

          //  cmd.Parameters.AddWithValue("@pno", pNo);
          //  conn.Open();
          //int result=   cmd.ExecuteNonQuery();
          //  conn.Close();

          //  if (result > 0)
          //  {
          //      Console.WriteLine("Product Deleted Successfully");
          //  }
          //  else
          //  {
          //      Console.WriteLine("Product Not Found in system");
          //  }



            #endregion



        }
    }
}
