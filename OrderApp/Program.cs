using OrderApp.Entities;
using OrderApp.Entities.Enums;

Console.WriteLine("Enter client data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date(DD/MM/YYYY: ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Client client = new Client(name, email, birthDate);

Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Order order = new Order(DateTime.Now, status, client);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter #" + i+1 + " item data:");
    Console.Write("Product name: ");
    string itemName = Console.ReadLine();

    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine());

    Product product = new Product(itemName, price);

    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    OrderItem orderItem = new OrderItem(quantity, price, product);

    order.AddItem(orderItem);
}

Console.WriteLine();
Console.WriteLine("SUMMARY:");
Console.WriteLine(order);
