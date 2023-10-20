/*
 * UPPGIFT 1
int[] numbers = new int[3];

for(int i = 0; i < 3; i++)
{
    Console.Write("Nummer " + (i + 1) + ": ");
    int.TryParse(Console.ReadLine(), out int nr);
    numbers[i] = nr;
}

bool isSum = numbers[0] + numbers[1] == numbers[2];
if(isSum)
{
    Console.WriteLine("Summan av de två första är lika med det tredje nummret");
} else
{
    Console.WriteLine("Summan av de två första talen är inte lika med det tredje nummret");
} */

/*
 * UPPGIFT 2
Console.Write("tal 1: ");
int.TryParse(Console.ReadLine(), out int nr1);

Console.Write("tal 2: ");
int.TryParse(Console.ReadLine(), out int nr2);

bool jämt = nr1 % 2 == 0;

int j = nr1;
if (!jämt) j += 1;

for(int i = j; i <= nr2; i += 2)
{
    Console.WriteLine(i);
} */

Console.Write("numret: ");
int.TryParse(Console.ReadLine(), out int nr);

int dela = 0;
if (100 % nr == 0) dela = 1;

int[] array = new int[ (100 / nr) - dela ];

int j = 0;

for(int i = nr; i < 100; i += nr)
{
    array[j] = i;
    j += 1;
    Console.WriteLine(i);
}
Console.WriteLine(j);

foreach(int i in array)
{
    Console.WriteLine(i);
} 