Console.WriteLine("Zadanie 4");
int roundsAmount;
while (true)
{
    Console.Write("Podaj liczbę tur od 1 do 10: ");
    string rounds = Console.ReadLine();
    bool correct = int.TryParse(rounds, out roundsAmount);

    if (!correct)
    {
        Console.WriteLine("Wpisz liczbę całkowitą.");
        continue;
    }

    if (roundsAmount < 1)
    {
        Console.WriteLine("Liczba musi należeć do zakresu 1–10.");
        continue;
    }

    if (roundsAmount > 10)
    {
        Console.WriteLine("Liczba musi należeć do zakresu 1–10.");
        continue;
    }

    break;
}

Console.WriteLine($"Rozpoczynam grę na {roundsAmount} tur.");
Console.Write("Odliczanie: ");
for (int round = roundsAmount; round >= 1; round--)
{
    Console.Write(round);
    Console.Write(" ");
}
