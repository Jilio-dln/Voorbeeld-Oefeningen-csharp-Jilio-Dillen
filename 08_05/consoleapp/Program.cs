int ReadNumber()
{
    int number;

    Console.Write("Geef een geheel getal: ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Ongeldig. Geef een geheel getal: ");
    }

    return number;
}

bool IsEven(int number)
{
    return number % 2 == 0;
}

List<int> GetEvenNumberBetween(int n1, int n2)
{
    List<int> numbers = new List<int>();

    for (int i = n1; i >= n2; i--)
    {
        if (IsEven(i))
        {
            numbers.Add(i);
        }
    }

    return numbers;
}

void PrintResult(List<int> numbers)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        Console.Write(numbers[i]);

        if (i < numbers.Count - 1)
        {
            Console.Write(" * ");
        }
    }

    Console.WriteLine();
}

int number1 = ReadNumber();
int number2 = ReadNumber();

List<int> result = GetEvenNumberBetween(number1, number2);

PrintResult(result);

Console.ReadLine();