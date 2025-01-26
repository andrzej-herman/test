var random = new Random();
Console.WriteLine("Program wygeneruje sekretną liczbę  przedziału 1-20");

var secretNumber = random.Next(1, 21);

var numberOfTries = 5;


if (numberOfTries > 0)
{
    Console.WriteLine("Podaj liczbę:");
    var text = Console.ReadLine();


    var number = int.Parse(text);
    if (number > secretNumber)
    {
        Console.WriteLine("Twoja liczba jest za duża");
        numberOfTries--;
    }
}





Console.ReadLine();
