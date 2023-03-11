// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] NewArray (int size, int min, int max)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().NextDouble() *100;
    }
    return arr;
}

double [] doubleArray = NewArray (5,0,1);
Console.WriteLine ($"массив вещественных чисел: [{String.Join("; ", doubleArray)}]");

double minValue = doubleArray[0];
double maxValue = doubleArray[0];

for (int i = 0; i < doubleArray.Length; i++)
{
    if (minValue > doubleArray[i])
    {
        minValue = doubleArray[i];
       
    }
}
Console.WriteLine ($"Минимальное число в массиве: {minValue}"); 

for (int i = 0; i < doubleArray.Length; i++)
{
    if (maxValue < doubleArray[i])
    {
        maxValue = doubleArray[i];
    }
}
Console.WriteLine ($"Максимальное число в массиве: {maxValue}");     

double differentNumber = 0;

Console.WriteLine (differentNumber = maxValue -minValue);


    

    

