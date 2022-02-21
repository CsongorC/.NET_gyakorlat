using System.Collections.Generic;
using System.Windows;

namespace ProductApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = stockCheck();
        }

        public List<DrinkProduct> stockCheck()
        {
            List<DrinkProduct> currentProduct = new List<DrinkProduct>();

            currentProduct.Add(new DrinkProduct { ProductId = "CF1kg", ProductName = "Coffee Powder", PackageType = "1 kg", Material = MaterialType.Powder, Quantity = 15684, AnnualSales = 1276 });
            currentProduct.Add(new DrinkProduct { ProductId = "CFB500", ProductName = "Ground Coffee", PackageType = "500 g", Material = MaterialType.Powder, Quantity = 22785, AnnualSales = 12856 });
            currentProduct.Add(new DrinkProduct { ProductId = "CFG500", ProductName = "Coffee Granules", PackageType = "500 g", Material = MaterialType.Granules, Quantity = 19233, AnnualSales = 5907 });
            currentProduct.Add(new DrinkProduct { ProductId = "Te500", ProductName = "Tea", PackageType = "500 g", Material = MaterialType.Leaf, Quantity = 8544, AnnualSales = 235 });
            currentProduct.Add(new DrinkProduct { ProductId = "TeInst500", ProductName = "Instant Tea", PackageType = "500 g", Material = MaterialType.Powder, Quantity = 1009, AnnualSales = 22 });
            currentProduct.Add(new DrinkProduct { ProductId = "SMlk1lt", ProductName = "Skimmed Milk", PackageType = "1 litre", Material = MaterialType.Liquid, Quantity = 28012, AnnualSales = 2650 });
            currentProduct.Add(new DrinkProduct { ProductId = "HiJ300", ProductName = "HiJuice Drink Mix", PackageType = "300 g", Material = MaterialType.Other, Quantity = 17523, AnnualSales = 179 });
            currentProduct.Add(new DrinkProduct { ProductId = "Sm400", ProductName = "Smoothie", PackageType = "400 ml", Material = MaterialType.Paste, Quantity = 9346, AnnualSales = 3284 });
            currentProduct.Add(new DrinkProduct { ProductId = "Beef300", ProductName = "Beef Drink", PackageType = "300 g", Material = MaterialType.Granules, Quantity = 8316, AnnualSales = 1965 });
            currentProduct.Add(new DrinkProduct { ProductId = "Beef750", ProductName = "Beef Drink", PackageType = "750 g", Material = MaterialType.Granules, Quantity = 7612, AnnualSales = 359 });

            return currentProduct;
        }
    }
}
