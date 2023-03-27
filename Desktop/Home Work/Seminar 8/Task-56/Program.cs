// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
//  с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7








int[,] table = NewTable(3, 2, 1, 9);
Console.WriteLine("Таблица чисел:");

int[,] NewTable(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);

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


int SumRows(int[,] row)

{
    int minRow = 0;
    int minSum = 0;
    for (int i = 0; i < row.GetLength(1); i++)
    {
        minSum += row[0, i];
    }


    for (int i = 1; i < row.GetLength(0); i++)
    {
        int sum = int.MinValue;
        for (int j = 0; j < row.GetLength(1); j++)
        {
            sum += row[i, j];
        }


        if (minSum > sum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    return minRow;
}
Console.WriteLine($" Сумма чисел  в строке самая минимальная {SumRows(table)}");
