using System.Globalization;
using ex_fix_enum.Entities;
using ex_fix_enum.Entities.Enums;

Console.WriteLine("Enter Client data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
Console.Write("How many items to this order? ");

Client client = new Client(name, email, birthDate);
Order order = new Order(DateTime.Now, status, client);

int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++) {
    Console.WriteLine($"Enter #{1} item data:");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product Price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Product product = new Product(productName, productPrice);

    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    OrderItem item = new OrderItem(quantity, productPrice, product);
    
    order.addItem(item);
}

Console.WriteLine();
Console.WriteLine("ORDER SUMMARY");
Console.WriteLine(order);