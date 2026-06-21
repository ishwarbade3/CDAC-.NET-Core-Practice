using ShoppingApplication.DAL;
using ShoppingApplication.Models;

namespace ShoppingApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new ShoppingAppDbContext();

            var cart = db.Carts.FirstOrDefault();

            if (cart == null)
            {
                Console.WriteLine("No cart found in database.");
                return;
            }

            // Create invoice
            var invoice = new Invoice
            {
                CartId = 2
            };

            db.Invoices.Add(invoice);
            db.SaveChanges();


            invoice = new Invoice
            {
                CartId = 1
            };

            db.Invoices.Add(invoice);

            db.SaveChanges();

            var invoices = db.Invoices.Where(invoice => invoice.CartId == 2).Select(c => new { c.InvoiceId, c.CartId }).ToList();
            

            Console.WriteLine($"Invoice Created Successfully. Invoice No = {invoice.InvoiceId}");
            Console.WriteLine(invoices);

           // PrintInvoice(db, invoice.InvoiceId);
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
