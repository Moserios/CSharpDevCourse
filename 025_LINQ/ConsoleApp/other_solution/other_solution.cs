using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToCollectionsAssignment
{
 // This is the Customer class, representing a customer who may place orders.
 public class Customer
 {
  public int CustomerID { get; set; } // Unique identifier for a customer
  public string FirstName { get; set; } // First name of the customer
  public string LastName { get; set; } // Last name of the customer
  public string Country { get; set; } // Country where the customer is located
 }


 // This is the Order class, representing an order placed by a customer.
 public class Order
 {
  public int OrderID { get; set; } // Unique identifier for an order
  public int CustomerID { get; set; } // Identifier for the customer who placed the order
  public DateTime OrderDate { get; set; } // Date on which the order was placed
  public DateTime? ShippedDate { get; set; } // Date on which the order was shipped, nullable
 }


 // This is the Product class, representing a product that may be ordered.
 public class Product
 {
  public int ProductID { get; set; } // Unique identifier for a product
  public string ProductName { get; set; } // Name of the product
  public decimal UnitPrice { get; set; } // Price of a single unit of the product
 }


 // This is the OrderDetail class, representing a line item in an order.
 public class OrderDetail
 {
  public int OrderDetailID { get; set; } // Unique identifier for an order detail
  public int OrderID { get; set; } // Identifier for the order to which the detail belongs
  public int ProductID { get; set; } // Identifier for the product in the order detail
  public int Quantity { get; set; } // Number of units of the product ordered
  public decimal Discount { get; set; } // Discount applied to the product in the order detail
 }



 class Program
 {
  static void Main()
  {
   // define a list of customers
   List<Customer> customers = new List<Customer>
        {
            new Customer { CustomerID = 1, FirstName = "John", LastName = "Doe", Country = "USA" },
            new Customer { CustomerID = 2, FirstName = "Jane", LastName = "Doe", Country = "USA" },
            new Customer { CustomerID = 3, FirstName = "Alice", LastName = "Smith", Country = "Canada" },
            new Customer { CustomerID = 4, FirstName = "Bob", LastName = "Smith", Country = "Canada" },
            new Customer { CustomerID = 5, FirstName = "Charlie", LastName = "Brown", Country = "USA" }
        };

   // Create some sample products
   List<Product> products = new List<Product>
        {
            new Product { ProductID = 1, ProductName = "Chai", UnitPrice = 18.00M },
            new Product { ProductID = 2, ProductName = "Chang", UnitPrice = 19.00M },
            new Product { ProductID = 3, ProductName = "Aniseed Syrup", UnitPrice = 10.00M },
            new Product { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", UnitPrice = 22.00M },
            new Product { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", UnitPrice = 21.35M },
            new Product { ProductID = 6, ProductName = "Grandma's Boysenberry Spread", UnitPrice = 25.00M },
            new Product { ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", UnitPrice = 30.00M },
            new Product { ProductID = 8, ProductName = "Northwoods Cranberry Sauce", UnitPrice = 40.00M },
            new Product { ProductID = 9, ProductName = "Mishi Kobe Niku", UnitPrice = 97.00M },
            new Product { ProductID = 10, ProductName = "Ikura", UnitPrice = 31.00M },
            new Product { ProductID = 11, ProductName = "Queso Cabrales", UnitPrice = 21.00M },
            new Product { ProductID = 12, ProductName = "Queso Manchego La Pastora", UnitPrice = 38.00M },
            new Product { ProductID = 13, ProductName = "Konbu", UnitPrice = 6.00M },
            new Product { ProductID = 14, ProductName = "Tofu", UnitPrice = 23.25M },
            new Product { ProductID = 15, ProductName = "Genen Shouyu", UnitPrice = 15.50M }
        };

   // define a list of orders
   List<Order> orders = new List<Order>
            {
                new Order { OrderID = 1, CustomerID = 1, OrderDate = new DateTime(2022, 1, 1), ShippedDate = new DateTime(2022, 1, 10) },
                new Order { OrderID = 2, CustomerID = 1, OrderDate = new DateTime(2022, 2, 1), ShippedDate = new DateTime(2022, 2, 10) },
                new Order { OrderID = 3, CustomerID = 2, OrderDate = new DateTime(2022, 3, 1), ShippedDate = new DateTime(2022, 3, 10) },
                new Order { OrderID = 4, CustomerID = 3, OrderDate = new DateTime(2022, 4, 1), ShippedDate = new DateTime(2022, 4, 10) },
                new Order { OrderID = 5, CustomerID = 4, OrderDate = new DateTime(2022, 5, 1), ShippedDate = new DateTime(2022, 5, 10) },
                new Order { OrderID = 6, CustomerID = 5, OrderDate = new DateTime(2022, 6, 1), ShippedDate = new DateTime(2022, 6, 10) },
                new Order { OrderID = 7, CustomerID = 1, OrderDate = new DateTime(2022, 7, 1), ShippedDate = new DateTime(2022, 7, 10) },
                new Order { OrderID = 8, CustomerID = 2, OrderDate = new DateTime(2022, 8, 1), ShippedDate = new DateTime(2022, 8, 10) },
                new Order { OrderID = 9, CustomerID = 3, OrderDate = new DateTime(2022, 9, 1), ShippedDate = new DateTime(2022, 9, 10) },
                new Order { OrderID = 10, CustomerID = 4, OrderDate = new DateTime(2022, 10, 1), ShippedDate = new DateTime(2022, 10, 10) }
                };

   // define a list of order details
   List<OrderDetail> orderDetails = new List<OrderDetail>()
            {
                new OrderDetail() { OrderDetailID = 1, OrderID = 1, ProductID = 1, Quantity = 5, Discount = 0.1m },
                new OrderDetail() { OrderDetailID = 2, OrderID = 1, ProductID = 2, Quantity = 3, Discount = 0m },
                new OrderDetail() { OrderDetailID = 3, OrderID = 2, ProductID = 3, Quantity = 2, Discount = 0.05m },
                new OrderDetail() { OrderDetailID = 4, OrderID = 2, ProductID = 4, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 5, OrderID = 3, ProductID = 5, Quantity = 4, Discount = 0m },
                new OrderDetail() { OrderDetailID = 6, OrderID = 4, ProductID = 6, Quantity = 2, Discount = 0m },
                new OrderDetail() { OrderDetailID = 7, OrderID = 4, ProductID = 7, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 8, OrderID = 5, ProductID = 8, Quantity = 3, Discount = 0m },
                new OrderDetail() { OrderDetailID = 9, OrderID = 5, ProductID = 9, Quantity = 2, Discount = 0m },
                new OrderDetail() { OrderDetailID = 10, OrderID = 5, ProductID = 10, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 11, OrderID = 6, ProductID = 1, Quantity = 4, Discount = 0m },
                new OrderDetail() { OrderDetailID = 12, OrderID = 7, ProductID = 2, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 13, OrderID = 7, ProductID = 3, Quantity = 2, Discount = 0m },
                new OrderDetail() { OrderDetailID = 14, OrderID = 7, ProductID = 4, Quantity = 3, Discount = 0.1m },
                new OrderDetail() { OrderDetailID = 15, OrderID = 8, ProductID = 5, Quantity = 7, Discount = 0m },
                new OrderDetail() { OrderDetailID = 16, OrderID = 8, ProductID = 6, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 17, OrderID = 9, ProductID = 7, Quantity = 2, Discount = 0m },
                new OrderDetail() { OrderDetailID = 18, OrderID = 10, ProductID = 8, Quantity = 3, Discount = 0m },
                new OrderDetail() { OrderDetailID = 19, OrderID = 10, ProductID = 9, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 20, OrderID = 10, ProductID = 10, Quantity = 4, Discount = 0m }
            };



   // Query 1: all customers in alphabetical order by last name
   var query1 = customers.OrderBy(c => c.LastName);


   // Query 2: all products in order of unit price, from highest to lowest
   var query2 = products.OrderByDescending(p => p.UnitPrice);


   // Query 3: all orders shipped in October 2021
   var query3 = orders.Where(o => o.ShippedDate?.Year == 2021 && o.ShippedDate?.Month == 10);


   // Query 4: all orders shipped to customers in the USA
   var query4 = orders.Where(o => customers.Any(c => c.CustomerID == o.CustomerID && c.Country == "USA"));


   // Query 5: all products that were ordered at least once, along with the total quantity ordered and the total revenue generated by each product
   var query5 = orderDetails
       .GroupBy(od => od.ProductID)
       .Select(g => new
       {
        ProductID = g.Key,
        TotalQuantity = g.Sum(od => od.Quantity),
        TotalRevenue = g.Sum(od => od.Quantity * products.Single(p => p.ProductID == od.ProductID).UnitPrice)
       })
       .Where(p => p.TotalQuantity > 0);


   // Query 6: the top 5 customers by the total amount of money they have spent, along with the number of orders they have placed and the average order amount
   /* In this query, we use the Join() extension method to join the customers, orders, orderDetails, and products collections. Then, we group the results by customer and calculate the total amount spent, number of orders, and average order amount for each customer. Finally, we order the results by total amount spent in descending order and take the top 5 customers, before outputting the required information for each of the top 5 customers. */
   var query6 = customers
       .Join(
           orders,
           customer => customer.CustomerID,
           order => order.CustomerID,
           (customer, order) => new { customer, order }
       )
       .Join(
           orderDetails,
           c => c.order.OrderID,
           orderDetail => orderDetail.OrderID,
           (c, orderDetail) => new { c.customer, c.order, orderDetail }
       )
       .Join(
           products,
           c => c.orderDetail.ProductID,
           product => product.ProductID,
           (c, product) => new { c.customer, c.order, c.orderDetail, product }
       )
       .GroupBy(
           c => c.customer,
           c => c,
           (customer, orderProducts) => new
           {
            Customer = customer,
            TotalAmountSpent = orderProducts.Sum(x => (x.orderDetail.Quantity * x.product.UnitPrice) * (1 - x.orderDetail.Discount)),
            NumberOfOrders = orderProducts.Select(x => x.order.OrderID).Distinct().Count(),
            AverageOrderAmount = orderProducts.Sum(x => (x.orderDetail.Quantity * x.product.UnitPrice) * (1 - x.orderDetail.Discount)) / orderProducts.Select(x => x.order.OrderID).Distinct().Count()
           }
       )
       .OrderByDescending(c => c.TotalAmountSpent)
       .Take(5);
   /* Explanation:
   This LINQ query performs a complex join operation on multiple collections and calculates various aggregated data for each customer.

   The first Join operation joins the Customers and Orders collections based on their common CustomerID field, creating a new anonymous object that contains both customer and order objects.

   The second Join operation further joins the previous result with the OrderDetails collection, based on the OrderID field, again creating a new anonymous object that contains customer, order, and order detail objects.

   The third Join operation finally joins the previous result with the Products collection, based on the ProductID field, creating a new anonymous object that contains all customer, order, order detail, and product objects.

   After the joins, the GroupBy operation groups the results by customer and applies aggregate functions on the order products for each customer, resulting in a new anonymous object that contains the customer, total amount spent by the customer, number of orders placed by the customer, and the average order amount for the customer.

   Finally, the results are ordered in descending order of the total amount spent and the top 5 results are returned using the Take method.
   */



   // Query 7: The most popular product by the number of times it has been ordered
   var query7 = orderDetails
       .GroupBy(od => od.ProductID)
       .Select(g => new
       {
        ProductID = g.Key,
        TotalQuantity = g.Sum(od => od.Quantity)
       })
       .OrderByDescending(p => p.TotalQuantity)
       .First();
   /*Explanation:
   GroupBy(od => od.ProductID) groups the OrderDetails objects by their ProductID, resulting in a collection of groups where each group contains all OrderDetails with the same ProductID.

   Select(g => new { ProductID = g.Key, TotalQuantity = g.Sum(od => od.Quantity) }) projects each group to a new anonymous object that contains the ProductID (the key of the group) and the total quantity of the product that has been ordered (the sum of the Quantity property of all OrderDetails in the group).

   OrderByDescending(p => p.TotalQuantity) orders the resulting sequence of anonymous objects by TotalQuantity in descending order.

   First() returns the first element of the ordered sequence, which is the anonymous object with the highest TotalQuantity. This represents the most popular product by the number of times it has been ordered.*/



   // Output
   Console.WriteLine("Query 1: All customers in alphabetical order by last name");
   foreach (var customer in query1)
   {
    Console.WriteLine($"{customer.FirstName} {customer.LastName}");
   }


   Console.WriteLine("\nQuery 2: All products in order of unit price, from highest to lowest");
   foreach (var product in query2)
   {
    Console.WriteLine($"{product.ProductName}: {product.UnitPrice:C}");
   }


   Console.WriteLine("\nQuery 3: All orders shipped in October 2021");
   foreach (var order in query3)
   {
    Console.WriteLine($"Order {order.OrderID}, shipped on {order.ShippedDate:d}");
   }


   Console.WriteLine("\nQuery 4: All orders shipped to customers in the USA");
   foreach (var order in query4)
   {
    Console.WriteLine($"Order {order.OrderID}, shipped to {customers.FirstOrDefault(c => c.CustomerID == order.CustomerID)?.Country}");
   }


   Console.WriteLine("\nQuery 5: All products that were ordered at least once, along with the total quantity ordered and the total revenue generated by each product");
   foreach (var product in query5)
   {
    Console.WriteLine($"Product: {products.Single(p => p.ProductID == product.ProductID).ProductName}");
    Console.WriteLine($"Total Quantity Ordered: {product.TotalQuantity}");
    Console.WriteLine($"Total Revenue Generated: {product.TotalRevenue:C}\n");
   }


   Console.WriteLine("\nQuery 6: The top 5 customers by the total amount of money they have spent, along with the number of orders they have placed and the average order amount");
   foreach (var customer in query6)
   {
    Console.WriteLine($"{customer.Customer.FirstName} {customer.Customer.LastName}: Total Amount Spent: {customer.TotalAmountSpent:C}, Number of Orders: {customer.NumberOfOrders}, Average Order Amount: {customer.AverageOrderAmount:C}");
   }


   Console.WriteLine("\nQuery 7: The most popular product by the number of times it has been ordered");
   var mostPopularProductName = products.Single(p => p.ProductID == query7.ProductID).ProductName;

   Console.WriteLine($"The most popular product is {mostPopularProductName}, which has been ordered {query7.TotalQuantity} times.");


   Console.ReadKey();
  }
 }
}