// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] table = NewTable (4, 3, 1, 9);
Console.WriteLine ("Таблица чисел:");

int[,] NewTable (int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    Console.WriteLine ("Введи число:");
    int enterNumber = Convert.ToInt32(Console.ReadLine());
    string result = "Не найдено";

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
        matrix[i, j] =new Random().Next(min, max);
        if (matrix [i,j] == enterNumber)
        {
            result = "Найдено";
        }                   
       }    
    }
     Console.WriteLine($" {enterNumber} {result} "); 
     return matrix;
}  

PrintTable(table);
void PrintTable (int[,] enterTable)
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




        