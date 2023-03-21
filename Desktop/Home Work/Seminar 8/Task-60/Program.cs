// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
//построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1
int[,,] array3D = NewArray (3,3,3,10,100);

int[,,] NewArray (int m, int n, int z, int min, int max)

{
    int [,,] matrix3D = new int [m,n,z];
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i,j,k] = new Random().Next(min, max);

                int firstNumber=matrix3D[i,j,k];
                int sameNumber=0;
                if( sameNumber==firstNumber ) break;
                if(sameNumber!=firstNumber ) firstNumber=sameNumber;
            }
        }
    }
    return matrix3D;
}

PrintMatrix3D(array3D);

void PrintMatrix3D (int[,,] cub )
{
    for (int i = 0; i < cub.GetLength(0); i++)
    {
        for (int j = 0; j < cub.GetLength(1); j++)
        {
            for (int k = 0; k < cub.GetLength(2); k++)
            {
                Console.Write($"{cub[i,j,k]} {(i,j,k)}  \t ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}