// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9





double[,] doubleTable = NewTable (3, 4, -5, 1);
Console.WriteLine ("Таблица вещественных чисел:");


double[,] NewTable (int m, int n, int min, int max)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
        matrix[i, j] =Math.Round( new Random().NextDouble()*100,2);
       } 

    }
    return matrix;
}
PrintTable(doubleTable);
void PrintTable (double[,] enterTable)
{
    for (int i = 0; i < enterTable.GetLength(0); i++)
    {
        for (int j = 0; j < enterTable.GetLength(1); j++)
        {
            Console.Write(enterTable[i,j] + "\t");
        }
        Console.WriteLine();
        
    }
}




