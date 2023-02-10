using Exercicio_HerancaEPolimorfismo.Entities;
using System.Globalization;

Console.Write("Enter the number of products: ");
int nProducts = Convert.ToInt32(Console.ReadLine());

List<Product> list= new List<Product>();

for(int i = 0;i < nProducts; i++)
{
    Console.WriteLine("Product #{0} data: ", i + 1);
    Console.Write("Common, used or imported (c/u/i)? ");
    char typeOfProduct = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string? name = Console.ReadLine();
    Console.Write("Price: ");
    double price = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (typeOfProduct == 'i' || typeOfProduct == 'I')
    {
        Console.Write("Custom fee: ");
        double customFee = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        Product importedProduct = new ImportedProduct(name, price, customFee);
        list.Add(importedProduct);
    }
    else if (typeOfProduct == 'u' || typeOfProduct == 'U')
    {
        Console.Write("Manufacture Date (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
        Product usedProduct = new UsedProduct(name, price, manufactureDate);
        list.Add(usedProduct);
    }
    else
    {
        Product product = new Product(name, price);
        list.Add(product);
    }
}

Console.WriteLine("PRICE TAGS: ");
foreach(Product product in list)
{
    Console.WriteLine(product);
}