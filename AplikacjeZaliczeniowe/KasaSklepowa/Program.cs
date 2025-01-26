using KasaSklepowa;

var allProducts = Warehouse.CreateProducts();
var basket = new List<Product>();

Console.WriteLine();
Console.Write("Podaj kod produktu: ");
var barcode = Console.ReadLine();

var product = allProducts.FirstOrDefault(p => p.Barcode == barcode);
if (product == null)
    Console.WriteLine("Brak produktu o takim kodzie");
else
{
    basket.Add(product);
    Console.WriteLine("Dodano produkt do koszyka");
}


product = allProducts.FirstOrDefault(p => p.Barcode == barcode);
if (product == null)
    Console.WriteLine("Brak produktu o takim kodzie");
else
{
    basket.Add(product);
    Console.WriteLine("Dodano produkt do koszyka");
}


Console.WriteLine();
Console.WriteLine("Paragon");
foreach (var pr in basket)
{
    Console.WriteLine($"{pr.Name} | {pr.Price} PLN");
}

var total = basket.Sum(p => p.Price);
Console.WriteLine($"Rzem do zapłaty: {total} PLN");


Console.ReadLine();

