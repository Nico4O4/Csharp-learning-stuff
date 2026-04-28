using System.ComponentModel.Design;

int []RandomNumbers = { 1, 3, 7, 5, 16, 223, 42, 64, 100, 100, 300, 400 };

Array.Sort(RandomNumbers);

for (int A = 0;     A < RandomNumbers.Length;   A++)
{
    Console.WriteLine(RandomNumbers[A]);
};

