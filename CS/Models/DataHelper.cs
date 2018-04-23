using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DxExample
{

    public static class DataHelper
    {
        public static BindingList<Category> GetData()
        {
            BindingList<Category> categoryBindingList = new BindingList<Category>();
            InitData(categoryBindingList);
            return categoryBindingList;
        }

        private static void InitData(BindingList<Category> categoryBindingList)
        {
            categoryBindingList.Add(new Category() { ID = 1, CategoryName = "Beverages", Description = "Soft drinks, coffees, teas, beers, and ales", Products = new BindingList<Product> { new Product() { ProductName = "Guaraná Fantástica", CategoryID = 1, UnitPrice = 4.5m } } });
            categoryBindingList.Add(new Category() { ID = 2, CategoryName = "Condiments", Description = "Sweet and savory sauces, relishes, spreads, and seasonings", Products = new BindingList<Product> { new Product() { ProductName = "Sir Corey's Scones", CategoryID = 2, UnitPrice = 110 }, new Product() { ProductName = "Sir Joes's Scones", CategoryID = 2, UnitPrice = 231.23m }, new Product() { ProductName = "Amanda's Scones", CategoryID = 2, UnitPrice = 31.23m } } });
            categoryBindingList.Add(new Category() { ID = 3, CategoryName = "Confections", Description = "Desserts, candies, and sweet breads", Products = new BindingList<Product> { new Product() { ProductName = "Sir Rodney's Scones", CategoryID = 3, UnitPrice = 10 }, new Product() { ProductName = "Gumbär Gummibärchen", CategoryID = 3, UnitPrice = 31.23m }, new Product() { ProductName = "NuNuCa Nuß-Nougat-Creme", CategoryID = 3, UnitPrice = 14 }, new Product() { ProductName = "Gumbär", CategoryID = 3, UnitPrice = 331.23m }, new Product() { ProductName = "Gummibärchen", CategoryID = 3, UnitPrice = 321.23m } } });
            categoryBindingList.Add(new Category() { ID = 4, CategoryName = "Dairy Products", Description = "Cheeses", Products = new BindingList<Product> { new Product() { ProductName = "Gorgonzola Telino", CategoryID = 4, UnitPrice = 12.5m }, new Product() { ProductName = "Gorgonzola", CategoryID = 4, UnitPrice = 112.5m }, new Product() { ProductName = "Telino", CategoryID = 4, UnitPrice = 122.5m } } });
            categoryBindingList.Add(new Category() { ID = 5, CategoryName = "Grains/Cereals", Description = "Breads, crackers, pasta, and cereal", Products = new BindingList<Product> { new Product() { ProductName = "Tunnbröd", CategoryID = 5, UnitPrice = 9 }, new Product() { ProductName = "Gustaf's Knäckebröd", CategoryID = 5, UnitPrice = 21 }, new Product() { ProductName = "Knäckebröd", CategoryID = 5, UnitPrice = 221 } } });
            categoryBindingList.Add(new Category() { ID = 6, CategoryName = "Meat/Poultry", Description = "Prepared meats", Products = new BindingList<Product> { new Product() { ProductName = "Thüringer Rostbratwurst", CategoryID = 6, UnitPrice = 123.79m }, new Product() { ProductName = "Thüringer", CategoryID = 6, UnitPrice = 223.79m }, new Product() { ProductName = "Rostbratwurst", CategoryID = 6, UnitPrice = 133.79m } } });
            categoryBindingList.Add(new Category() { ID = 7, CategoryName = "Produce", Description = "Dried fruit and bean curd", Products = new BindingList<Product> { new Product() { ProductName = "Rössle Sauerkraut", CategoryID = 7, UnitPrice = 45.6m }, new Product() { ProductName = "Rössle", CategoryID = 7, UnitPrice = 55.6m }, new Product() { ProductName = "Sauerkraut", CategoryID = 7, UnitPrice = 35.6m } } });
            categoryBindingList.Add(new Category() { ID = 8, CategoryName = "Seafood", Description = "Seaweed and fish", Products = new BindingList<Product> { new Product() { ProductName = "Nord-Ost Matjeshering", CategoryID = 8, UnitPrice = 25.89m }, new Product() { ProductName = "Nord-Ost", CategoryID = 8, UnitPrice = 23.89m }, new Product() { ProductName = "Nord Matjeshering", CategoryID = 8, UnitPrice = 29.89m } } });
        }
    }
}
