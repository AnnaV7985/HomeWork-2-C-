// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] resArray = NewArray(10, 100, 999);
Console.WriteLine($"массив: [{String.Join("," , resArray)}]");

int[] NewArray (int size, int min, int max)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max); 
    }
    return array;
}

int countFind =0;
for (int i = 0; i < resArray.Length; i++)
{
    if (resArray[i]%2 == 0)
    {
        countFind ++ ;
    }
}
Console.WriteLine($"Четных чисел в массиве {countFind}");
