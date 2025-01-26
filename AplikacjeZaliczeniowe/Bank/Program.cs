using Bank;

var customers = new List<Customer>();
customers.Add(new Customer("1", "Tomasz", "Nowak", 1500));
customers.Add(new Customer("2", "Agata", "Kowalska", 1000));
customers.Add(new Customer("3", "Leszek", "Polski", 500));

foreach (var customer in customers)
{
    Console.WriteLine($"{customer.FullName} | Saldo: {customer.Saldo} PLN");
}


Console.WriteLine("Wybierz klienta podając jego ID: ");
var id = Console.ReadLine();

var selectedCustomer = customers.FirstOrDefault(c => c.Id == id);

if (selectedCustomer != null)
{
    Console.WriteLine($"Wybrałeś Klienta: {selectedCustomer.FullName} | Saldo: {selectedCustomer.Saldo} PLN");

}

Console.WriteLine("Wybierz klienta do ktorego idzie przelew: ");
id = Console.ReadLine();



var paymentCustomer = customers.FirstOrDefault(c => c.Id == id);

var amount = Console.ReadLine();


var czyUdaloSieZamienic = decimal.TryParse(amount, out decimal result);
if (czyUdaloSieZamienic)
{
    if (result >= selectedCustomer.Saldo)
        Console.WriteLine("Brak wystarczających środków");
    else
    {
        if (paymentCustomer != null)
        {
            selectedCustomer.Saldo = selectedCustomer.Saldo - result;
            paymentCustomer.Saldo = paymentCustomer.Saldo + result;

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.FullName} | Saldo: {customer.Saldo} PLN");
            }

        }


    }
}




Console.ReadLine();
