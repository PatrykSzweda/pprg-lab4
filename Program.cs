Console.WriteLine("Zadanie 2");
Console.WriteLine("Ile dni trwa wyprawa?");
string adventure = Console.ReadLine();
int adventureDays = int.Parse(adventure);
int totalGold = 0;
int success = 0; 
for (int day = 1; day <= adventureDays; day++)
{
    Console.WriteLine($"Złoto w dniu {day}:");
    string gold = Console.ReadLine();
    int goldAmount= int.Parse(gold);
    
    totalGold += goldAmount; 
    if (goldAmount > 10)
    {
        success++;
    }
}
Console.WriteLine($"Łącznie znaleziono: {totalGold} sztuk złota.");
Console.WriteLine($"Dni z wynikiem powyżej 10: {success}.");
