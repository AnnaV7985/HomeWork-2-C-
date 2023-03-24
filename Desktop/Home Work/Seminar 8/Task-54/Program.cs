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










// void ChangeArray(int[,] matrix)
//  {
//      int[,] number = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//      {
//          for (int j =0 ; j < matrix.GetLength(1); j++) 
//          {
//             j =0;
//             int max = 0;
//             int temp = number [0, j];
//             if(number [0,j]> max)
//             {number [0,j] = number [max, j];
//             number[max, j] = temp;

//             }
//  Console.WriteLine($"Результат: {number[i,j]}" ); 
//              }
//          }

//      }



//  ChangeArray(table);
//  PrintTable(table);




// 1 4 7 2














// PrintTable (DescentNumbers(table));
// int DescentNumbers (int m, int n, )
// {
//     int[,] namber = new int[m,n];
//     int maxElement = int.MaxValue;
//     for (int i = 0; i < m; i++)
//     {
//         if(i>maxElement)
//               {
//                 maxElement=i;
//               }
//         for (int j = 0; j < n; j++)
//         {
//            namber[i,j]= new Random().Next(); 

//         }

//     }
//     return namber;
// }


// // // int lastRow = matrix.GetLength(0) - 1; // matrix = new int[3(стр),3], 3 - 1 = 2
// //  for (int i = 0; i < matrix.GetLength(1); i++)
// //  {
// //  int temp = matrix[0, i]; // temp = 1
// //  matrix[0, i] = matrix[lastRow, i]; // matrix[0,0] = matrix[2,0]

// //  matrix[lastRow, i] = temp;
// //  }
// int rows = 3;
// int cols = 3;

// int[,] matrix = new int[rows, cols]; //3;3

// int min = int.MaxValue; // Больше, чем число 2147483647 в Int32 не бывает
// // Минимальное число или равно MaxValue, или меньше
// int indexMinRows = 0; // Номер строчки с мин
// int indexMinCols = 0;  // Номер столбца с мин

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < cols; j++)
//     {
//         matrix[i, j] = new Random().Next(11); // 0-10
//         Console.Write(matrix[i, j] + "\t");
//         if (min > matrix[i, j])
//         {
//             min = matrix[i, j];
//             indexMinRows = i;
//             indexMinCols = j;
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine($"Минимум: {min}, строчка: {indexMinRows}, столбец: {indexMinCols} ");

// for (int i = 0; i < rows; i++)
// {
//     if (indexMinRows != i) // Исключаем строчку с минимальным числом
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             if (indexMinCols != j)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//         }
//         Console.WriteLine();