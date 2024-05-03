class Sample
{
    static void Main()
    {
        //create a reference variables
        Product product1, product2, product3, product4;

        //create and objects
        product1 = new Product();
        Product.numberOfProducts++;

        product2 = new Product();
        Product.numberOfProducts++;
        product3 = new Product();
        Product.numberOfProducts++;
        product4 = new Product();
        Product.numberOfProducts++;

        //initialise a fileds

        product1.productId = 0001;
        product1.productType = "phone";
        product1.productName = "iPhone 15 pro max 1gb";
        product1.cost = 250000;
        product1.quautityInStock = 1000;

        product2.productId = 0002;
        product2.productType = "laptop";
        product2.productName = "Acer Predator Helios 18 2024";
        product2.cost = 450000;
        product2.quautityInStock = 100;

        product3.productId = 0003;
        product3.productType = "car";
        product3.productName = "Lexus RX 400h 2009";
        product3.cost = 750000;
        product3.quautityInStock = 10;

        product4.productId = 0004;
        product4.productType = "appartment";
        product4.productName = "3 bedroom appartment";
        product4.cost = 1500000;
        product4.quautityInStock = 1;

        

        //get values from the object
        System.Console.WriteLine($"\nProduct {product1.productId} Type: {product1.productType}");
        System.Console.WriteLine($"Product {product1.productId} Name: {product1.productName}");
        System.Console.WriteLine($"Product {product1.productId} Cost: {product1.cost}");
        System.Console.WriteLine($"Product {product1.productId} Quantity: {product1.quautityInStock}");
        System.Console.WriteLine($"Product {product1.productId} Date of Purchase: {product1.dateOfPurchase}");

        System.Console.WriteLine($"\nProduct {product2.productId} Type: {product2.productType}");
        System.Console.WriteLine($"Product {product2.productId} Name: {product2.productName}");
        System.Console.WriteLine($"Product {product2.productId} Cost: {product2.cost}");
        System.Console.WriteLine($"Product {product2.productId} Quantity: {product2.quautityInStock}");
        System.Console.WriteLine($"Product {product2.productId} Date of Purchase: {product2.dateOfPurchase}");

        System.Console.WriteLine($"\nProduct {product3.productId} Type: {product3.productType}");
        System.Console.WriteLine($"Product {product3.productId} Name: {product3.productName}");
        System.Console.WriteLine($"Product {product3.productId} Cost: {product3.cost}");
        System.Console.WriteLine($"Product {product3.productId} Quantity: {product3.quautityInStock}");
        System.Console.WriteLine($"Product {product3.productId} Date of Purchase: {product3.dateOfPurchase}");

        System.Console.WriteLine($"\nProduct {product4.productId} Type: {product4.productType}");
        System.Console.WriteLine($"Product {product4.productId} Name: {product4.productName}");
        System.Console.WriteLine($"Product {product4.productId} Cost: {product4.cost}");
        System.Console.WriteLine($"Product {product4.productId} Quantity: {product4.quautityInStock}");
        System.Console.WriteLine($"Product {product4.productId} Date of Purchase: {product4.dateOfPurchase}");

        System.Console.WriteLine($"\nProducts category: {Product.CategoryName}.");
        System.Console.WriteLine($"\nProducts number: {Product.numberOfProducts}.");
        System.Console.WriteLine($"\nTotal Products quantity in stock: {product1.quautityInStock + product2.quautityInStock + product3.quautityInStock + product4.quautityInStock}.");


        System.Console.ReadKey();
    }
}