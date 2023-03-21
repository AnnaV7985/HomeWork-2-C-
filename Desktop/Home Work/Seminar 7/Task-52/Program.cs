// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] table = NewTable(3, 4, 1, 9);
Console.WriteLine("Таблица чисел:");

int[,] NewTable(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }

    return matrix;
}

PrintTable(table);

void PrintTable(int[,] enterTable)
{
    for (int i = 0; i < enterTable.GetLength(0); i++)
    {
        for (int j = 0; j < enterTable.GetLength(1); j++)
        {
            Console.Write(enterTable[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"Среднеарифметическое число столбца:  ");
for (int i = 0; i < table.GetLength(1); i++)
{
    double arifmetic = 0;

    for (int j = 0; j < table.GetLength(0); j++)
    {
        arifmetic = arifmetic + table[j, i];
    }
    Console.Write(Math.Round(arifmetic / table.GetLength(0), 2) + "     ");
}
