using ShoppingApplication.DAL;
using ShoppingApplication.Models;

namespace ShoppingApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new ShoppingAppDbContext();

            // CATEGORY
            //var category = new Category
            //{
            //    CategoryName = "Electronics",
            //    CategoryDescription = "Electronic Products"
            //};

            ////db.Categories.Add(category);
            //db.SaveChanges();

            //// PRODUCTS
            //var product1 = new Product
            //{
            //    ProductName = "Laptop",
            //    ProductDescription = "Dell Inspiron",
            //    UnitPrice = 50000,
            //    Quantity = 10,
            //    CategoryId = category.CategoryId
            //};

            //var product2 = new Product
            //{
            //    ProductName = "Mouse",
            //    ProductDescription = "Wireless Mouse",
            //    UnitPrice = 1000,
            //    Quantity = 50,
            //    CategoryId = category.CategoryId
            //};

            //db.Products.Add(product1);
            //db.Products.Add(product2);
            //db.SaveChanges();

            //// CUSTOMER
            //var customer = new Customer
            //{
            //    CustomerName = "Ishwar Bade",
            //    CustomerCity = "Pune"
            //};

            //db.Customers.Add(customer);
            //db.SaveChanges();

            //// CART
            //var cart = new Cart
            //{
            //    CustomerId = customer.CustomerId
            //};

            //db.Carts.Add(cart);
            //db.SaveChanges();

            //// CART ITEMS
            //var item1 = new CartItem
            //{
            //    CartId = cart.CartId,
            //    ProductId = product1.ProductId,
            //    Quantity = 1
            //};

            //var item2 = new CartItem
            //{
            //    CartId = cart.CartId,
            //    ProductId = product2.ProductId,
            //    Quantity = 2
            //};

            //db.CartItems.Add(item1);
            //db.CartItems.Add(item2);
            //db.SaveChanges();

            //// INVOICE
            //var invoice = new Invoice
            //{
            //    CartId = cart.CartId
            //};

            //db.Invoices.Add(invoice);
            //db.SaveChanges();

            //Console.WriteLine($"Invoice Created : {invoice.InvoiceId}");

            // PRINT INVOICE

            Console.Write("Enter Invoice Number: ");

            if (int.TryParse(Console.ReadLine(), out int invoiceId))
            {
                PrintInvoice(db, invoiceId);
            }
            else
            {
                Console.WriteLine("Invalid Invoice Number!");
            }
        }

         static void PrintInvoice(ShoppingAppDbContext db, int invoiceId)
        {
            var invoice = db.Invoices.FirstOrDefault(i => i.InvoiceId == invoiceId);

            if (invoice == null)
            {
                Console.WriteLine("Invoice not found!");
                return;
            }

            var cart = db.Carts.First(c => c.CartId == invoice.CartId);

            var customer = db.Customers.First(c => c.CustomerId == cart.CustomerId);

            var cartItems = db.CartItems
                .Where(ci => ci.CartId == cart.CartId)
                .ToList();

            decimal grandTotal = 0;

            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine("         SHOPPING INVOICE");
            Console.WriteLine("==================================");

            Console.WriteLine($"Invoice No : {invoice.InvoiceId}");
            Console.WriteLine($"Customer   : {customer.CustomerName}");
            Console.WriteLine($"City       : {customer.CustomerCity}");
            Console.WriteLine();

            foreach (var item in cartItems)
            {
                var product = db.Products.First(p => p.ProductId == item.ProductId);

                decimal lineTotal = product.UnitPrice * item.Quantity;
                grandTotal += lineTotal;

                Console.WriteLine(
                    $"{product.ProductName,-15} Qty:{item.Quantity,-3} Price:{product.UnitPrice,-10} Total:{lineTotal}");
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Grand Total : {grandTotal}");
            Console.WriteLine("==================================");
        }
    }
    }
