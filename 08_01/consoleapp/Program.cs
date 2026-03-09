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

string ReadLetter()
{
    string letter;

    do
    {
        Console.Write("Geef lettercode (A/B): ");
        letter = Console.ReadLine().ToUpper();

    } while (letter != "A" && letter != "B");

    return letter;
}

int Sum(int x, int y)
{
    int som = x + y;
    return som;
}

int Subtract(int x, int y)
{
    int verschil = x - y;
    return verschil;
}

void PrintResult(int n1, int n2, string operation, int result)
{

    Console.WriteLine($"{n1} {operation} {n2} = {result}");
}

int getal1, getal2, getal3;
string letter;
char cijfer;

getal1 = ReadNumber();
getal2 = ReadNumber();
getal3 = ReadNumber();
letter = ReadLetter();

Console.Write("Geef cijfercode (1/2/3): ");
cijfer = Convert.ToChar(Console.ReadLine());

switch (letter)
{
    case "A":
        switch (cijfer)
        {
            case '1':
                PrintResult(getal1, getal2, "+", Sum(getal1, getal2));
                break;

            case '2':
                PrintResult(getal2, getal3, "+", Sum(getal2, getal3));
                break;

            case '3':
                PrintResult(getal1, getal3, "+", Sum(getal1, getal3));
                break;

            default:
                Console.WriteLine("Ongeldige cijfercode.");
                break;
        }
        break;

    case "B":
        switch (cijfer)
        {
            case '1':
                PrintResult(getal1, getal2, "-", Subtract(getal1, getal2));
                break;

            case '2':
                PrintResult(getal2, getal3, "-", Subtract(getal2, getal3));
                break;

            case '3':
                PrintResult(getal1, getal3, "-", Subtract(getal1, getal3));
                break;

            default:
                Console.WriteLine("Ongeldige cijfercode.");
                break;
        }
        break;

    default:
        Console.WriteLine("Ongeldige lettercode.");
        break;
}




Console.ReadLine();