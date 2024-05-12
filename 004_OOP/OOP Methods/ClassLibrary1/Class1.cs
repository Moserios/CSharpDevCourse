using System.Security.Cryptography.X509Certificates;

public class Product
{
    //fields
    private string productType;
    private int productId;
    private string productName;
    private double cost;
    private double tax;
    private int quautityInStock;
    public static int numberOfProducts;
    public const string CategoryName = "Industrial Products"; //common for all objects
    private readonly string dateOfPurchase; //value will be assigned at each object independently


    //Constructor
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }


    // set-get productID method
    public void SetProductID(int value)
    {
        productId = value;
    }

    public int GetProductID()
    { 
        return productId;
    }

    // set-get productType
    public void SetProductType(string value)
    {
        productType = value;
    }

    public string GetProductType()
    {
        return productType;
    }

    // set-get productName
    public void SetProductName(string value)
    {
        productName = value;
    }

    public string GetProductName()
    {
        return productName;
    }

    // set-get cost
    public void SetCost(double value)
    {
        cost = value;
    }

    public double GetCost()
    {
        return cost;
    }


    // set-get quautityInStock
    public void SetQuautityInStock(int value)
    {
        quautityInStock = value;
    }

    public int GetQuautityInStock()
    {
        return quautityInStock;
    }

    // set-get numberOfProducts
    public static void SetNumberOfProducts(int value)
    {
        numberOfProducts = value;
    }

    public static int GetNumberOfProducts()
    {
        return numberOfProducts;
    }


    // get dateOfPurchase
    public string GetDateOfPurchase()
    {
        return dateOfPurchase;
    }

    // get CategoryName
    public string GetCategoryName()
    {
        return CategoryName;
    }




    //method to calculate tax for product.
    //if cost < 20000 => tax = 10%, else tax = 12.5%

    public void CalculateTax(double tax_size = 10.0)
    { 
        double t;

        if (cost >= 20000)
        {
            t = cost / 100 * 12.5;
        }
        else 
        {
            t = cost / 100 * tax_size;
        }

        tax = t;
    
    }

    // set-get tax
    public void SetTax(double value)
    {
        tax = value;
    }

    public double GetTax()
    {
        return tax;
    }

}

//child class in the same assembly
public class FoodProduct : Product
{
    //fields

}
