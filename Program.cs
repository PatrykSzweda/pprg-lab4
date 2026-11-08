Console.WriteLine("Zadanie 1");
int increase = 1;
Console.Write("Rosnąco: ");
while (increase <= 10 )
{
    Console.Write(increase);
    Console.Write(" ");
    increase++;
}
Console.WriteLine("(While)");
int increaseSecond = 1;
Console.Write("Rosnąco: ");
do
{
        Console.Write(increaseSecond);
    Console.Write(" ");
    increaseSecond++;
}
while (increaseSecond <= 10 );
Console.WriteLine("(Do-while)");
Console.Write("Rosnąco: ");
for (int increaseThird = 1; increaseThird <= 10; increaseThird++)
{
    Console.Write(increaseThird);
    Console.Write(" ");
}
Console.WriteLine("(For)");

Console.Write("Malejąco: ");
for (int decrease = 10; decrease >= 0; decrease--)
{
    Console.Write(decrease);
    Console.Write(" ");
}

Console.WriteLine("");
Console.Write("Parzyste: ");
for (int even = 0; even <= 20; even += 2)
{
    Console.Write(even);
    Console.Write(" ");
}

Console.WriteLine("");
Console.WriteLine("Start!");

// Która pętla najczytelniej opisuje znaną liczbę powtórzeń? - for;
// Ile razy wykona się while, jeśli jej warnek od początku jest fałszywy? - 0;
// Ile razy w tej samej sytuacji wykona się do-while? - 1;