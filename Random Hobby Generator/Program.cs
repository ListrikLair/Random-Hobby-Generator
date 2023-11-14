// See https://aka.ms/new-console-template for more information
Random rand = new Random();
var randomNumber = rand.Next(0, 4);

Console.WriteLine("Who would like to get a new hobby?");
var text = Console.ReadLine();
TextGenerator(text);
void TextGenerator(string name)
{
    string returnText;
    if (randomNumber == 0)
    {
        Console.WriteLine($"{name} is suddenly very interested in botany.");
    }
    else if (randomNumber == 1)
    {
        Console.WriteLine($"Oh no! {name} just became an evil overlord!");
    }
    else if (randomNumber == 2)
    {
        Console.WriteLine($"I've never seen someone run as fast as {name}.");
    }
    else if (randomNumber == 3)
    {
        Console.WriteLine($"Horses. {name} just can't get enough of them.");
    }
    else if (randomNumber == 4)
    {
        Console.WriteLine($"{name} desperately loves fishing, it is all they're able to think about.");
    }
};