using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Tasks:
//Create a new console application in Visual Studio.

//Define four classes: Customer, Product, Order, and OrderDetail. Add appropriate properties to each class.


//Model classes
//Consider the following model classes for customers, orders, products and order details.

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




namespace Orders
{
    internal class Program
    {
        static void Main()
        {

            //Create some sample data for the Customers, Products, Orders, and OrderDetails lists. Add at least 5 customers, 15 products, 5 orders, and 10 order details.
            //Sample data: Consider the following sample data for customers, orders, products and order details.

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


            //Write LINQ queries to perform the following tasks:

            //a.Display a list of all customers in alphabetical order by last name.
            Console.WriteLine($"\nList of all customeres ordered by Last Name");
            var selectedCustomers = customers.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
            foreach (Customer customer in selectedCustomers)
            {
                Console.WriteLine($"{customer.CustomerID}, {customer.FirstName}, {customer.LastName}, {customer.Country}");
            }


            //b. Display a list of all products in order of unit price, from highest to lowest.
            Console.WriteLine($"\nList of all products sorted by unitprice from high to low");
            var allProducts = products.OrderByDescending(x => x.UnitPrice);
            foreach (Product product in allProducts)
            {
                Console.WriteLine($"{product.ProductID}, {product.ProductName}, {product.UnitPrice}");
            }


            //c. Display a list of all orders that were shipped in October 2021.
            Console.WriteLine($"\nList of all orders that were shipped in October 2021");
            var octoberOrders = orders.Where(x => x.ShippedDate >= new DateTime(2021, 10, 1) && x.ShippedDate < new DateTime(2021, 11, 1));

            if (octoberOrders.Any())
            {
                foreach (Order order in octoberOrders)
                {
                    Console.WriteLine($"{order.OrderID}, {order.CustomerID}, {order.OrderDate}");
                }
            }
            else
            {
                Console.WriteLine("No required records found");
            }



            //d. Display a list of all orders that were shipped to customers in the USA.
            Console.WriteLine($"\nList of all orders that were shipped to customers in the USA");
            var usaCustomers = customers.Where(x => x.Country == "USA");
            var shippedToUsaOrders = orders.Where(x => usaCustomers.Select(y => y.CustomerID).Contains(x.CustomerID));


            if (shippedToUsaOrders.Any())
            {
                foreach (Order order in shippedToUsaOrders)
                {
                    Console.WriteLine($"Order: {order.OrderID}, CustomerID: {order.CustomerID}, Order Date:{order.OrderDate}, Shippment Date: {order.ShippedDate}");
                }
            }
            else
            {
                Console.WriteLine("No required records found");
            }



            //e. Display a list of all products that were ordered at least once,
            //along with the total quantity ordered and the total revenue generated by each product.

            Console.WriteLine($"\nlist of ordered products with the total quantity and the total revenue generated by each product");
            //var soldProducts = from Product in products
            //                   join OrderDetail in orderDetails on Product.ProductID equals OrderDetail.ProductID 
            //                   select new 
            //                   {
            //                       ProductID = Product.ProductID, 
            //                       ProductName = Product.ProductName, 
            //                       UnitPrice = Product.UnitPrice, 
            //                       Quantity = OrderDetail.Quantity, 
            //                       Discount = OrderDetail.Discount , 
            //                       TotalRevenue = OrderDetail.Quantity * Product.UnitPrice * (1 - OrderDetail.Discount)
            //                   };

            var groupedProducts = from Product in products
                                  join OrderDetail in orderDetails on Product.ProductID equals OrderDetail.ProductID
                                  group new { Product, OrderDetail } by new { Product.ProductID, Product.ProductName, Product.UnitPrice } into grouped
                                  select new
                                  {
                                      ProductID = grouped.Key.ProductID,
                                      ProductName = grouped.Key.ProductName,
                                      UnitPrice = grouped.Key.UnitPrice,
                                      TotalQuantity = grouped.Sum(g => g.OrderDetail.Quantity),
                                      TotalRevenue = grouped.Sum(g => g.OrderDetail.Quantity * g.Product.UnitPrice * (1 - g.OrderDetail.Discount))
                                  };

            foreach (var item in groupedProducts)
            {
                Console.WriteLine($"ID: {item.ProductID}, Name: {item.ProductName}, UnitPrice: {item.UnitPrice}, Quantity: {item.TotalQuantity}, TotalRevenue: {item.TotalRevenue}");
            }


            //f. Display a list of the top 5 customers by the total amount of money they have spent, along with the number of orders they have placed and the average order amount.
            Console.WriteLine($"\nlist of the top 5 customers by the spent money with the number of placed orders and the average order amount");
            var customersOrders = from Order in orders
                                  join Customer in customers on Order.CustomerID equals Customer.CustomerID
                                  //group new { Order, Customer } by new { Order.OrderID, Order.CustomerID} into grouped
                                  select new
                                  {
                                      OrderID = Order.OrderID,
                                      CustomerID = Order.CustomerID,
                                      FirstName = Customer.FirstName,
                                      LastName = Customer.LastName
                                  };

            var personalizedOrders = from customersOrder in customersOrders
                                     join OrderDetails in orderDetails on customersOrder.OrderID equals OrderDetails.OrderID
                                     select new
                                     {
                                         OrderID = customersOrder.OrderID,
                                         CustomerID = customersOrder.CustomerID,
                                         FirstName = customersOrder.FirstName,
                                         LastName = customersOrder.LastName,
                                         ProductID = OrderDetails.ProductID,
                                         Quantity = OrderDetails.Quantity,
                                         Discount = OrderDetails.Discount
                                     };


            var goodsAndOrders = from personalizedOrder in personalizedOrders
                                 join Product in products on personalizedOrder.ProductID equals Product.ProductID
                                 select new
                                 {
                                     personalizedOrder.OrderID,
                                     personalizedOrder.CustomerID,
                                     personalizedOrder.FirstName,
                                     personalizedOrder.LastName,
                                     ProductID = personalizedOrder.ProductID,
                                     Quantity = personalizedOrder.Quantity,
                                     Discount = personalizedOrder.Discount,
                                     ProductName = Product.ProductName,
                                     UnitPrice = Product.UnitPrice,
                                     OrderAmount = personalizedOrder.Quantity * Product.UnitPrice * (1 - personalizedOrder.Discount)
                                 };


            var orderWithTotalAmount = from order in goodsAndOrders
                                       group order by order.OrderID into OrderGroup
                                       select new
                                       {
                                           OrderID = OrderGroup.Key,
                                           CustomerID = OrderGroup.First().CustomerID,
                                           FirstName = OrderGroup.First().FirstName,
                                           LastName = OrderGroup.First().LastName,
                                           OrderTotalAmount = OrderGroup.Sum(x => x.OrderAmount)
                                       };


            var totalResults = from order in orderWithTotalAmount
                               group order by new { order.CustomerID, order.FirstName, order.LastName } into CustomerGroup
                               select new
                               {
                                   CustomerID = CustomerGroup.Key.CustomerID,
                                   CustomerName = $"{CustomerGroup.Key.FirstName} {CustomerGroup.Key.LastName}",
                                   TotalAmount = CustomerGroup.Sum(x => x.OrderTotalAmount),
                                   NumberOfOrders = CustomerGroup.Select(x => x.OrderID).Distinct().Count(),
                                   AverageOrder = CustomerGroup.Average(x => x.OrderTotalAmount)
                               };




            //example: Bob Smith: Total Amount Spent: Rs. 686.00, Number of Orders: 2, Average Order Amount: Rs. 343.00
            var top5 = totalResults.OrderByDescending(x => x.TotalAmount);

            foreach (var item in top5)
            {
                Console.WriteLine($"{item.CustomerName}: Total Amount Spent: {item.TotalAmount}, Number of Orders: {item.NumberOfOrders}, Average Order Amount: {item.AverageOrder}");
            }

            //g. The most popular product by the number of times it has been ordered.
            Console.WriteLine($"\nThe most popular product by the number of times it has been ordered");
            //var popularProduct = orderDetails.OrderByDescending(x => x.Quantity).ThenBy(x => x.ProductID);

            var popularProductIDs = from order in orderDetails
                                        //join product in products on order.ProductID equals product.ProductID
                                    group order by order.ProductID into ProductGroup
                                    select new
                                    {
                                        ProductID = ProductGroup.Key,
                                        OrderTotalAmount = ProductGroup.Sum(x => x.Quantity)
                                    };

            var popularProducts = from order in popularProductIDs
                                  join product in products on order.ProductID equals product.ProductID
                                  select new
                                  {
                                      product.ProductID,
                                      product.ProductName,
                                      TotalOrders = order.OrderTotalAmount
                                  };
            var sortedProducts = popularProducts.OrderByDescending(x => x.TotalOrders);

            Console.WriteLine($"{sortedProducts.First().ProductName} {sortedProducts.First().TotalOrders}");

            Console.ReadKey();
        }
    }
}

//Make sure to use LINQ to collections only, without connecting to a database or using Entity Framework.

//Add comments to your code to explain what each section of code is doing.

//Test your application to ensure that it works as expected.
//Sample output:

//Query 1: All customers in alphabetical order by last name
//Charlie Brown
//John Doe
//Jane Doe
//Alice Smith
//Bob Smith

//Query 2: All products in order of unit price, from highest to lowest
//Mishi Kobe Niku: Rs. 97.00
//Northwoods Cranberry Sauce: Rs. 40.00
//Queso Manchego La Pastora: Rs. 38.00
//Ikura: Rs. 31.00
//Uncle Bob's Organic Dried Pears: Rs. 30.00
//Grandma's Boysenberry Spread: Rs. 25.00
//Tofu: Rs. 23.25
//Chef Anton's Cajun Seasoning: Rs. 22.00
//Chef Anton's Gumbo Mix: Rs. 21.35
//Queso Cabrales: Rs. 21.00
//Chang: Rs. 19.00
//Chai: Rs. 18.00
//Genen Shouyu: Rs. 15.50
//Aniseed Syrup: Rs. 10.00
//Konbu: Rs. 6.00

//Query 3: All orders shipped in October 2021

//Query 4: All orders shipped to customers in the USA
//Order 1, shipped to USA
//Order 2, shipped to USA
//Order 3, shipped to USA
//Order 6, shipped to USA
//Order 7, shipped to USA
//Order 8, shipped to USA

//Query 5: All products that were ordered at least once, along with the total quantity ordered and the total revenue generated by each product
//Product: Chai
//Total Quantity Ordered: 9
//Total Revenue Generated: Rs. 162.00


//Product: Chang
//Total Quantity Ordered: 4
//Total Revenue Generated: Rs. 76.00


//Product: Aniseed Syrup
//Total Quantity Ordered: 4
//Total Revenue Generated: Rs. 40.00


//Product: Chef Anton's Cajun Seasoning
//Total Quantity Ordered: 4
//Total Revenue Generated: Rs. 88.00


//Product: Chef Anton's Gumbo Mix
//Total Quantity Ordered: 11
//Total Revenue Generated: Rs. 234.85


//Product: Grandma's Boysenberry Spread
//Total Quantity Ordered: 3
//Total Revenue Generated: Rs. 75.00


//Product: Uncle Bob's Organic Dried Pears
//Total Quantity Ordered: 3
//Total Revenue Generated: Rs. 90.00


//Product: Northwoods Cranberry Sauce
//Total Quantity Ordered: 6
//Total Revenue Generated: Rs. 240.00


//Product: Mishi Kobe Niku
//Total Quantity Ordered: 3
//Total Revenue Generated: Rs. 291.00


//Product: Ikura
//Total Quantity Ordered: 5
//Total Revenue Generated: Rs. 155.00



//Query 6: The top 5 customers by the total amount of money they have spent, along with the number of orders they have placed and the average order amount
//Bob Smith: Total Amount Spent: Rs. 686.00, Number of Orders: 2, Average Order Amount: Rs. 343.00
//John Doe: Total Amount Spent: Rs. 277.40, Number of Orders: 3, Average Order Amount: Rs. 92.47
//Jane Doe: Total Amount Spent: Rs. 259.85, Number of Orders: 2, Average Order Amount: Rs. 129.93
//Alice Smith: Total Amount Spent: Rs. 140.00, Number of Orders: 2, Average Order Amount: Rs. 70.00
//Charlie Brown: Total Amount Spent: Rs. 72.00, Number of Orders: 1, Average Order Amount: Rs. 72.00


//Query 7: The most popular product by the number of times it has been ordered
//The most popular product is Chef Anton's Gumbo Mix, which has been ordered 11 times.
//Submission:


//Submit your completed code as a single ".cs" file.

//Make sure your code is well-organized and easy to read. Write essential c# comments that explains each piece of the code.