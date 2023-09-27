using ProductShop.Data;
using System.IO;
using ProductShop.XMLHelper;
using ProductShop.Dtos.Import;
using ProductShop.Dtos.Export;
using System.Linq;
using ProductShop.Models;
using System;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using ProductShopContext context = new ProductShopContext();

            //context.Database.EnsureDeleted();
            //Console.WriteLine("Db was successfully deleted!");
            //context.Database.EnsureCreated();
            //Console.WriteLine("Db was successfully created!");

            //string inputUserXml = File.ReadAllText("../../../Datasets/users.xml");
            //string inputProductsXml = File.ReadAllText("../../../Datasets/products.xml");
            //string inputCategoriesXml = File.ReadAllText("../../../Datasets/categories.xml");
            //string inputCatProdXml = File.ReadAllText("../../../Datasets/categories-products.xml");

            //var result = ImportUsers(context, inputUserXml);
            //var result1 = ImportProducts(context, inputProductsXml);
            //var result2 = ImportCategories(context, inputCategoriesXml);
            //var result3 = ImportCategoryProducts(context, inputCatProdXml);

            //System.Console.WriteLine(result);
            //System.Console.WriteLine(result1);
            //System.Console.WriteLine(result2);
            //System.Console.WriteLine(result3);

            var productsInRange = GetSoldProducts(context);
            //var productsInRange = GetCategoriesByProductsCount(context);

            File.WriteAllText("../../../results/users-sold-products.xml", productsInRange);
            //File.WriteAllText("../../../results/categories-by-products.xml", productsInRange);

        }

        //01
        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            const string rootElement = "Users";
            var userResult = XmlConverter.Deserializer<ImportUserDto>(inputXml, rootElement);

            var users = userResult.Select(u => new User
            {
                FirstName = u.FirstName,
                LastName = u.LastName,
                Age = u.Age
            })
            .ToArray();

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Length}";
        }

        //02
        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            const string rootElement = "Products";
            var userResult = XmlConverter.Deserializer<ImportProductDto>(inputXml, rootElement);

            var products = userResult.Select(u => new Product
            {
                Name = u.Name,
                Price = u.Price,
                SellerId = u.SellerId,
                BuyerId = u.BuyerId
            })
            .ToArray();

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Length}";
        }

        //03
        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            const string rootElement = "Categories";
            var userResult = XmlConverter.Deserializer<ImportCategoriesDto>(inputXml, rootElement);

            var categories = userResult
                .Where(c => c.Name != null)
                .Select(u => new Category
                {
                    Name = u.Name
                })
                .ToArray();

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Length}";
        }

        //04
        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            const string rootElement = "CategoryProducts";
            var userResult = XmlConverter.Deserializer<ImportCategoryProductDto>(inputXml, rootElement);

            var categoryProds = userResult
                .Where(u => context.Categories.Any(c=> c.Id == u.CategoryId) && context.Products.Any(p => p.Id == u.ProductId))
                .Select(u => new CategoryProduct
                {
                    CategoryId = u.CategoryId,
                    ProductId = u.ProductId
                })
                .ToArray();

            context.CategoryProducts.AddRange(categoryProds);
            context.SaveChanges();

            return $"Successfully imported {categoryProds.Length}";
        }

        //05
        public static string GetProductsInRange(ProductShopContext context)
        {
            const string rootElement = "Products";
            
            var products = context.Products
                .Where(p => p.Price >=500 && p.Price <=1000)
                .Select(p => new ExportProductDto
                {
                    Name = p.Name,
                    Price = p.Price,
                    Buyer = p.Buyer.FirstName + " " + p.Buyer.LastName
                })
                .OrderBy(p => p.Price)
                .Take(10)
                .ToArray();

            var result = XmlConverter.Serialize<ExportProductDto>(products, rootElement);

            return result;
        }

        //06
        public static string GetSoldProducts(ProductShopContext context)
        {
            const string rootElement = "Users";

            var users = context.Users
                .Where(u => u.ProductsSold.Any())
                .Select(u => new ExportUserSoldProductsDto
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    SoldProducts = u.ProductsSold.Select( p => new UserProductsDto
                    {
                        Name = p.Name,
                        Price = p.Price
                    })
                    .ToArray()
                })
                .OrderBy(l => l.LastName)
                .ThenBy(f => f.FirstName)
                .Take(5)
                .ToArray();

            var result = XmlConverter.Serialize<ExportUserSoldProductsDto>(users, rootElement);

            return result;
        }

        //07
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            const string rootElement = "Products";

            var products = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .Select(p => new ExportProductDto
                {
                    Name = p.Name,
                    Price = p.Price,
                    Buyer = p.Buyer.FirstName + " " + p.Buyer.LastName
                })
                .OrderBy(p => p.Price)
                .Take(10)
                .ToArray();

            var result = XmlConverter.Serialize<ExportProductDto>(products, rootElement);

            return result;
        }
    }
}