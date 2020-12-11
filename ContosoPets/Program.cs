using ContosoPets.Data;
using ContosoPets.Models;
using System;
using System.Linq;

namespace ContosoPets
{
    class Program
    {
        static void Main(string[] args)
        {

            // We create a new instance of ContosoPetsContext with using statement so that we ensure ContosoPetsContext objetc is disposed off properly after we're done using it.
            using ContosoPetsContext context = new ContosoPetsContext();




            /*
            // Editing Data
            var squeakyBone = context.Products
                                .Where(p => p.Name == "Squeaky Dog Bone")
                                .FirstOrDefault(); // incase we don't have the record we get null

            if (squeakyBone is Product) // To check to see if squeakyBone is a Product
            {
                squeakyBone.Price = 7.99m; // if it is a product we set the price for 7.99m
            }
            context.SaveChanges();
            */

            // Deleting a data from the database
            var squeakyBone = context.Products
                    .Where(p => p.Name == "Squeaky Dog Bone")
                    .FirstOrDefault(); // incase we don't have the record we get null

            if (squeakyBone is Product) // To check to see if squeakyBone is a Product
            {
                context.Remove(squeakyBone); // if it is a product we set the price for 7.99m
            }
            context.SaveChanges();



            // LINQ method does the same thing as the Fluent API in the below example
            var products = from product in context.Products
                           where product.Price > 5.00m
                           orderby product.Name
                           select product;


            /*
            // Fluent APIs use extension methods that chain methods together and lamda (p=> p.) expressions to specify the query
            var products = context.Products
                .Where(p => p.Price >= 5.00m)
                .OrderBy(p => p.Name);
            */




            // Reading Data to console from database

            foreach (Product p in products)
            {
                Console.WriteLine($"Id: {p.Id}");
                Console.WriteLine($"Name: {p.Name}");
                Console.WriteLine($"Price: {p.Price}");
                Console.WriteLine(new string('-', 20));
            }



           











            /*
            // Adding data to database

            Product squeakyBone = new Product()
            {
                Name = "Squeaky Dog Bone",
                Price = 4.99M
            };
            context.Products.Add(squeakyBone);

            Product tennisBalls = new Product()
            {
                Name = "Tennis Ball 3-Pack",
                Price = 9.99M
            };
            context.Add(tennisBalls); // Here we don't have to use the context.Products.Add since entity framework knows that is a product value

            context.SaveChanges();
             // now after using it we can erase and then run the code up there to call the data to our console.
            */
        }
    }
}
