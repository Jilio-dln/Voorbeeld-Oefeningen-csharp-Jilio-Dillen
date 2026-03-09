int ReadNumber()
{
    int number;

    Console.Write("Geef een geheel getal: ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Ongeldige invoer. Geef een geheel getal: ");
    }

    return number;
}

string ReadSymbol(string compareSymbol)
{
    string symbol;

    do
    {
        Console.Write("Geef een symbool: ");
        symbol = Console.ReadLine();
    }
    while (symbol.Length != 1 || symbol == compareSymbol);

    return symbol;
}

string MakeLine(string symbol, int length)
{
    string line = "";

    for (int i = 1; i <= length; i++)
    {
        line += symbol;
    }

    return line;
}

string CreateScarf(string line1, string line2, int length)
{
    string scarf = "";

    for (int i = 1; i <= length; i++)
    {
        if (i % 2 == 1)
        {
            scarf += line1 + "\n";
        }
        else
        {
            scarf += line2 + "\n";
        }
    }

    return scarf;
}

string symbol1 = ReadSymbol("");
string symbol2 = ReadSymbol(symbol1);

int length = ReadNumber();
int width = ReadNumber();

string line1 = MakeLine(symbol1, width);
string line2 = MakeLine(symbol2, width);

string scarf = CreateScarf(line1, line2, length);

Console.WriteLine(scarf);

Console.ReadLine();