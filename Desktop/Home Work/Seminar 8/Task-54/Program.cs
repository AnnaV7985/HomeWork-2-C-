// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] table = NewTable(4, 3, 1, 9);
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
PrintTable(table);

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        for (int k = j + 1; k < table.GetLength(1); k++)
        {
            if (table[i, k] > table[i, j])
            {
                int temp = table[i, j];
                table[i, j] = table[i, k];
                table[i, k] = temp;
            }
        }
    }
}
Console.WriteLine("Упорядочивание чисел по убыванию:");
PrintTable(table);






