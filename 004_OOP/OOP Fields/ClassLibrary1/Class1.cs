public class Product
{
    //fields
    public string productType;
    public int productId;
    public string productName;
    public double cost;
    public int quautityInStock;
    public static int numberOfProducts;
    public const string CategoryName = "Industrial Products"; //common for all objects
    public readonly string dateOfPurchase; //value will be assigned at each object independently


    //Constructor
    public Product()
    {
        dateOfPurchase =System.DateTime.Now.ToShortDateString();
    }

}

//child class in the same assembly
public class FoodProduct: Product
{
    //fields
    
}
