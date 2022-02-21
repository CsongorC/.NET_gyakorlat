namespace ProductApp
{
    public enum MaterialType { Granules, Leaf, Liquid, Paste, Powder, Other }
    public class DrinkProduct
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string PackageType { get; set; }
        public MaterialType Material { get; set; }
        public int AnnualSales { get; set; }
        public int Quantity { get; set; }
    }
}