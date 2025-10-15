using WebApp_Day8.Models;

namespace WebApp_Day8.Data
{
    public static class EShopInitializer 
    {
        public static void Seed(EShopV10 context)
        {
            if(context.Categories.Any() || context.Products.Any() || context.Customers.Any())
            {
                return; // DB has been seeded
            }   
            var categories = new List<Category>
            {
                new Category { Name = "Category 1", NameVN = "Description 1" },
                new Category { Name = "Category 2", NameVN = "Description 2" },
                new Category { Name = "Category 3", NameVN = "Description 3" }
            };
            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();
            var products = new List<Product>
            {
                new Product { Name = "Product 1", Description = "Description 1", UnitPrice = 10.0, CategoryId = categories[0].Id },
                new Product { Name = "Product 2", Description = "Description 2", UnitPrice = 20.0, CategoryId = categories[1].Id },
                new Product { Name = "Product 3", Description = "Description 3", UnitPrice = 30.0, CategoryId = categories[2].Id }
            };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
            var customers = new List<Customer>
            {
                new Customer { Id = "user1", Password = "pass1", FullName = "User One", Email = "tung@gmail.com", Photo = "1234567890", Activated = true }
            };
            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();
        }
    }
}
