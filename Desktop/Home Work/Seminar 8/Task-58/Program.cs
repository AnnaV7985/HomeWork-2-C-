// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] table1 = NewTable(2, 2, 1, 9);
Console.WriteLine("Первая таблица чисел:");
PrintTable(table1);
int[,] table2 = NewTable(2, 2, 1, 9);
Console.WriteLine("Вторая таблица чисел:");
PrintTable(table2);

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

int[,] MultiplicationTable (int[,] matrix1, int[,] matrix2)
{
    int [,]result = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i <result.GetLength(0); i++)
    {
        for (int j = 0; j <result.GetLength(1); j++)
    {
        for (int k = 0; k < result.GetLength(1); k++)
        {
            result[i,j] = matrix1[i,j] * matrix2[i,j];
        }
            
    }
    }
    return result;
}

       
 
Console.WriteLine();
PrintTable(MultiplicationTable (table1, table2));

