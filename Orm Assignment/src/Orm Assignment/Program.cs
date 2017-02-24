using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orm_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new Models())
            {
                db.Database.Migrate();
                db.product.Add(new Product_Table
                {
                    Name = "Dell",
                    Description = "Monitor",
                    HomePageUrl = "www.dell.com",
                });
                var count = db.SaveChanges();
                db.product.Add(new Product_Table
                {
                    Name = "Tvs",
                    Description = "Keyboard",
                    HomePageUrl = "www.tvs.com",
                });
                count = db.SaveChanges();
                db.product.Add(new Product_Table
                {
                    Name = "Logitech",
                    Description = "Mouse",
                    HomePageUrl = "www.logitech.com",
                });
                count = db.SaveChanges();
                db.Update.Add(new Update_Table
                {
                    Name = "Dell-Keyboard",
                    Description = "Gaming Keyboard",
                    Foreign_Id = 1
                });
                count = db.SaveChanges();
                db.Update.Add(new Update_Table
                {
                    Name = "Logitech Monitor",
                    Description = "Dd-Monitor",
                    Foreign_Id = 2
                });
                count = db.SaveChanges();
                db.Update.Add(new Update_Table
                {
                    Name = "Tvs",
                    Description = "Headphone",
                    Foreign_Id = 3
                });
                count = db.SaveChanges();

            }
            using (var db = new Models())
            {
                db.product.Update(new Product_Table
                {
                    ProductId = 1,
                    Name = "Dell",
                    Description = "Hd-Monitor",
                    HomePageUrl = "https://www.Delldell.com"
                });
                var count = db.SaveChanges();
                db.Update.Update(new Update_Table
                {
                    UpdateId = 2,
                    Foreign_Id = 2,
                    Name = "Logitech-Monitor",
                    Description = "Smart t.v",
                });
                count = db.SaveChanges();

            }
            using (var db = new Models())
            {
                db.Update.Remove(new Update_Table
                {
                    UpdateId = 2,
                    Foreign_Id = 2,
                    Name = "Logitech-Monitor"
                });
                var count = db.SaveChanges();
                db.product.Remove(new Product_Table
                {
                    ProductId = 2,
                    Name = "Logitech-Monitor",
                    Description = "Smart t.v",
                });
                count = db.SaveChanges();

            }
            Console.Read();
        }
    }
}
