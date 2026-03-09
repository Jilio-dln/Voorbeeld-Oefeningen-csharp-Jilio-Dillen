int ReadNumber(int min, int max)
{
    int number;

    Console.Write($"Geef een landingsplaats ({min}-{max}): ");
    while (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max)
    {
        Console.Write($"Ongeldig. Geef een getal tussen {min} en {max}: ");
    }

    return number;
}

int CalculateScore(List<int> throws)
{
    int score = 0;

    foreach (int t in throws)
    {
        switch (t)
        {
            case 1:
                score += 0;
                break;

            case 2:
                score += 20;
                break;

            case 3:
                score += 50;
                break;

            case 4:
                score += 100;
                break;
        }
    }

    return score;
}

void ShowScore(int score)
{
    Console.WriteLine($"U hebt {score} punten behaald!");
}

List<int> throws = new List<int>();

for (int i = 1; i <= 3; i++)
{
    int gooiwaarde = ReadNumber(1, 4);
    throws.Add(gooiwaarde);
   
}

int score = CalculateScore(throws);

ShowScore(score);


Console.ReadLine();