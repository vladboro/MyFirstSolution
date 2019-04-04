using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DemoDB;Integrated Security=True;Pooling=False"))
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("SELECT * FROM Users ORDER BY Age", conn);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        Console.WriteLine("Id = {0}, First = {1}, Last = {2}, Age = {3}", dr[0], dr[1], dr[2], dr[3]);
            //    }
            //    dr.Close();
            //}
            //DemoDataSet ds = new DemoDataSet();
            //DemoDataSetTableAdapters.UsersTableAdapter usersTableAdapter = new DemoDataSetTableAdapters.UsersTableAdapter();
            //usersTableAdapter.Fill(ds.Users);
            //foreach (var user in ds.Users)
            //{
            //    var u = new { user.Id, user.FirstName, user.LastName, Age = user.Age.ToString() };

            //    Console.WriteLine("Id = {0}, First = {1}, Last = {2}", u.Id, u.FirstName, u.LastName);
            //}

            //usersTableAdapter.Update(ds.Users);

            //DemoDBEntities context = new DemoDBEntities();
            //var users = from u in context.Users
            //            where u.Groups.Count > 1
            //            select new { u.Id, u.FirstName, u.LastName, GroupsCount = u.Groups.Count };
            //foreach (var user in users)
            //{
            //    Console.WriteLine("Id = {0}, First = {1}, Last = {2}, GroupsCount = {3}", user.Id, user.FirstName, user.LastName, user.GroupsCount);
            //}

            //EDMDesignerContainer context = new EDMDesignerContainer();
            //Product[] products = new Product[] {
            //                                    new Product { Name = "Product1", Price = 20 },
            //                                    new Product { Name = "Product2", Price = 10 },
            //                                    new Product { Name = "Product3", Price = 30 } };
            //context.Products.AddRange(products);
            //context.SaveChanges();

            DAL.EDMCodeFirst context = new DAL.EDMCodeFirst();
            foreach (var category in context.Categories)
            {
                Console.WriteLine(category.Name);
            }
        }
    }

    // class UserData
}
