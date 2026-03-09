int ReadHobby(int min, int max)
{
    int number;

    Console.Write($"Geef een hobby in ({min}-{max}): ");
    while (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max)
    {
        Console.Write($"Ongeldig. Geef een hobby tussen {min} en {max}: ");
    }

    return number;
}

string ReadName(string prompt)
{
    string naam;

    do
    {
        Console.Write(prompt);
        naam = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(naam));

    return naam;
}

void RecommendBooks(List<int> hobbies)
{
    if (hobbies.Count == 0)
    {
        Console.WriteLine("Wij raden niets aan.");
    }

    foreach (int hobby in hobbies)
    {
        if (hobby == 1)
        {
            Console.WriteLine("Wij raden \"Anna\" aan.");
        }
        if (hobby == 2)
        {
            Console.WriteLine("Wij raden \"Knippie\" aan.");
        }
        if (hobby == 3)
        {
            Console.WriteLine("Wij raden \"VtWonen\" aan.");
        }
        if (hobby == 4)
        {
            Console.WriteLine("Wij raden \"Voetbal International\" aan.");
        }
        if (hobby == 5)
        {
            Console.WriteLine("Wij raden \"Wandelen & fietsen\" aan.");
        }
        if (hobby == 6)
        {
            Console.WriteLine("Wij raden \"Zoom NL\" aan.");
        }
        if (hobby == 7)
        {
            Console.WriteLine("Wij raden \"Runners\" aan.");
        }
    }
}
string voornaam = ReadName("Geef je voornaam: ");
string familienaam = ReadName("Geef je familienaam: ");


Console.WriteLine("Kies een hobby:");
Console.WriteLine("1 - Handwerk");
Console.WriteLine("2 - Kleding maken");
Console.WriteLine("3 - Interieur");
Console.WriteLine("4 - Voetballen");
Console.WriteLine("5 - Fietsen");
Console.WriteLine("6 - Fotografie");
Console.WriteLine("7 - Lopen");
Console.WriteLine("8 - Stop");

List<int> hobbies = new List<int>();

int hobby = ReadHobby(1, 8);

while (hobby != 8)
{
    hobbies.Add(hobby);
    hobby = ReadHobby(1, 8);
}

RecommendBooks(hobbies);

Console.ReadLine();