// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] NewArray (int size, int min, int max)
{
    int[] arr = new int [size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min,max);
    }
    return arr;
}
int[] resArray = NewArray (5, 1, 10);
Console.WriteLine ($"В массиве: [{String.Join(",", resArray)}]");
int oddNumber = 0;
for (int i = 0; i < resArray.Length; i++)
{
    if (resArray[i] % 2 != 0) 
    {
       oddNumber += resArray[i];
    }
}
Console.WriteLine ($"Сумма нечетных чисел: {oddNumber}");