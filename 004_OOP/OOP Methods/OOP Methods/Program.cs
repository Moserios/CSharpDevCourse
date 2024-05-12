using System;

class Sample
{
    static void Main()
    {
        //create a reference variables
        Product product1, product2, product3, product4;

        //create and objects    
        product1 = new Product();
        Product.SetNumberOfProducts(Product.GetNumberOfProducts()+1);

        product2 = new Product();
        Product.SetNumberOfProducts(Product.GetNumberOfProducts() + 1);
        product3 = new Product();
        Product.SetNumberOfProducts(Product.GetNumberOfProducts() + 1);
        product4 = new Product();
        Product.SetNumberOfProducts(Product.GetNumberOfProducts() + 1);

        //initialise a fileds

        product1.SetProductID(0001);
        product1.SetProductType("phone");
        product1.SetProductName("iPhone 15 pro max 1gb");
        product1.SetCost(2500);
        product1.SetQuautityInStock(1000);

        product2.SetProductID(0002);
        product2.SetProductType("laptop");
        product2.SetProductName("Acer Predator Helios 18 2024");
        product2.SetCost(4500);
        product2.SetQuautityInStock(100);

        product3.SetProductID(0003);
        product3.SetProductType("car");
        product3.SetProductName("Lexus RX 400h 2009");
        product3.SetCost(15000);
        product3.SetQuautityInStock(10);

        product4.SetProductID(0004);
        product4.SetProductType("appartment");
        product4.SetProductName("3 bedroom appartment");
        product4.SetCost(150000);
        product4.SetQuautityInStock(1);

        //Calling a method

        product1.CalculateTax(5);
        product2.CalculateTax(10);
        product3.CalculateTax(tax_size: 7.5);
        product4.CalculateTax();


        System.Console.WriteLine(product1.GetTax());
        System.Console.WriteLine(product2.GetTax());
        System.Console.WriteLine(product3.GetTax());
        System.Console.WriteLine(product4.GetTax());

        System.Console.WriteLine($"\nProduct {product1.GetProductID()} Type: {product1.GetProductType()}");
        System.Console.WriteLine($"Product {product1.GetProductID()} Name: {product1.GetProductName()}");
        System.Console.WriteLine($"Product {product1.GetProductID()} Cost: {product1.GetCost()}");
        System.Console.WriteLine($"Product {product1.GetProductID()} Quantity: {product1.GetQuautityInStock()}");
        System.Console.WriteLine($"Product {product1.GetProductID()} Date of Purchase: {product1.GetDateOfPurchase()}");

        System.Console.WriteLine($"\nProduct {product2.GetProductID()} Type: {product2.GetProductType()}");
        System.Console.WriteLine($"Product {product2.GetProductID()} Name: {product2.GetProductName()}");
        System.Console.WriteLine($"Product {product2.GetProductID()} Cost: {product2.GetCost()}");
        System.Console.WriteLine($"Product {product2.GetProductID()} Quantity: {product2.GetQuautityInStock()}");
        System.Console.WriteLine($"Product {product2.GetProductID()} Date of Purchase: {product2.GetDateOfPurchase()}");

        System.Console.WriteLine($"\nProduct {product3.GetProductID()} Type: {product3.GetProductType()}");
        System.Console.WriteLine($"Product {product3.GetProductID()} Name: {product3.GetProductName()}");
        System.Console.WriteLine($"Product {product3.GetProductID()} Cost: {product3.GetCost()}");
        System.Console.WriteLine($"Product {product3.GetProductID()} Quantity: {product3.GetQuautityInStock()}");
        System.Console.WriteLine($"Product {product3.GetProductID()} Date of Purchase: {product3.GetDateOfPurchase()}");

        System.Console.WriteLine($"\nProduct {product4.GetProductID()} Type: {product4.GetProductType()}");
        System.Console.WriteLine($"Product {product4.GetProductID()} Name: {product4.GetProductName()}");
        System.Console.WriteLine($"Product {product4.GetProductID()} Cost: {product4.GetCost()}");
        System.Console.WriteLine($"Product {product4.GetProductID()} Quantity: {product4.GetQuautityInStock()}");
        System.Console.WriteLine($"Product {product4.GetProductID()} Date of Purchase: {product4.GetDateOfPurchase()}");

        System.Console.WriteLine($"\nProducts category: {Product.CategoryName}.");
        System.Console.WriteLine($"\nProducts number: {Product.GetNumberOfProducts()}.");
        System.Console.WriteLine($"\nTotal Products quantity in stock: {product1.GetQuautityInStock() + product2.GetQuautityInStock() + product3.GetQuautityInStock() + product4.GetQuautityInStock()}.");


        System.Console.ReadKey();
    
    }
}
