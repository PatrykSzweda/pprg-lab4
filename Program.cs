Console.WriteLine("Zadanie 3");
Console.Write("Podaj wysokość choinki (2-10): ");
string height = Console.ReadLine();
int treeHeight = int.Parse(height);
if (treeHeight >= 2 && treeHeight <= 10)
{
for (int line = 1; line <= treeHeight; line++)
{
    for (int space = 1; space <= treeHeight - line; space++)
    {
        Console.Write(" ");
    }
    for (int star = 1; star <= (2 * line - 1); star++ )
    {
        Console.Write("*");   
    }
   Console.WriteLine();
}
for (int space = 1; space <= treeHeight - 1; space++)
    {
        Console.Write(" ");
    }
    Console.WriteLine("*");
}
else
{
    Console.WriteLine("Podana wysokość jest spoza zakresu 2-10!");
}

// Wyjaśnij, jak zmienia się liczba spacji i gwiazdek w kolejnych wierszach oraz ile gwiazdek znajduje się w ostatnim wierszu korony:
// Liczba spacji zmienia sie tak, że w każdej kolejnej linii jest jedna mniej, poprzez pętle, np w pierwszej linii liczba spacji jest rónwna wysokości choinki - 1;
// Liczba gwiazdek wzrasta w każdej linii o 2, przykładowo w linii 3 nastepuje równanie: 2 * 3 - 1, czyli w 3 linii bedzie 5 gwiazdek.
// W ostatnim wierszu ilość gwiazdek zależy od wysokości choinki, w przypadku 10 jest to 2 * 10 - 1, czyli 19 gwiazdek. 