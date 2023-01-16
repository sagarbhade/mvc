﻿namespace DAL;
using BOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class DBManager
{
    public static List<Product> GetAllProducts(){
        List<Product> allProducts=new List<Product>();
        allProducts.Add(new Product { ProductId = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", Balance = 5000 });
            allProducts.Add(new Product { ProductId = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Category = "Flower", Balance = 7000 });
            allProducts.Add(new Product { ProductId = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Category = "Flower", Balance = 3400 });
            allProducts.Add(new Product { ProductId = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", UnitPrice = 16, Category = "Flower", Balance = 27000 });
            allProducts.Add(new Product { ProductId = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.", UnitPrice = 6, Category = "Flower", Balance = 1000 });
            allProducts.Add(new Product { ProductId = 6, Title = "Jasmine", Description = "Jasmine is a genus of shrubs and vines in the olive family", UnitPrice = 26, Category = "Flower", Balance = 2000 });
            allProducts.Add(new Product { ProductId = 7, Title = "Daisy", Description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", UnitPrice = 36, Category = "Flower", Balance = 159 });
            allProducts.Add(new Product { ProductId = 8, Title = "Aster", Description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", UnitPrice = 16, Category = "Flower", Balance = 67 });
            allProducts.Add(new Product { ProductId = 9, Title = "Daffodil", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", Balance = 5000 });
            allProducts.Add(new Product { ProductId = 10, Title = "Dahlia", Description = "Dahlias are a popular and glamorous summer flower.", UnitPrice = 7, Category = "Flower", Balance = 0 });
            allProducts.Add(new Product { ProductId = 11, Title = "Hydrangea", Description = "Hydrangea is the fourth wedding anniversary flower", UnitPrice = 12, Category = "Flower", Balance = 0 });
            allProducts.Add(new Product { ProductId = 12, Title = "Orchid", Description = "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", UnitPrice = 10, Category = "Flower", Balance = 700 });
            allProducts.Add(new Product { ProductId = 13, Title = "Statice", Description = "Surprise them with this fresh, fabulous array of Statice flowers", UnitPrice = 16, Category = "Flower", Balance = 1500 });
            allProducts.Add(new Product { ProductId = 14, Title = "Sunflower", Description = "Sunflowers express your pure love.", UnitPrice = 8, Category = "Flower", Balance = 2300 });
            allProducts.Add(new Product { ProductId = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", UnitPrice = 17, Category = "Flower", Balance = 10000 });
            return allProducts;
    }
    public static List<Product> GetAllProductsFromFile(string path){       
            if(File.Exists(path)){
                string jsonString=File.ReadAllText(path);
            List<Product> allProducts=JsonSerializer.Deserialize<List<Product>>(jsonString);
            return allProducts ;
            }
            else
            {
                return GetAllProducts();
            }  
            
        }
        public static bool WriteAllProductsToFile(string path,List<Product> allProducts){
            bool status=false;
            string jsonString=JsonSerializer.Serialize(allProducts);
            File.WriteAllText(path, jsonString);
            status=true;
            return status;
        }


        public static List<Product> GetAllProductsFromDatabase()
        {
            List<Product> allProducts = new List<Product>();
            //ProductDAL.GetAll();
            //using mysql
            //database connectivity using ADO.NET (Rdbms)
            //database connectivity using ORM (Entity Framework)
            //database connectivity using mongoDB
            return allProducts;
        }
        public static List<Product> GetAllProductsFromDatabase1()
        {
            List<Product> allProducts = new List<Product>();
            
            //get All json data from REST API
            
            return allProducts;
        }
}
