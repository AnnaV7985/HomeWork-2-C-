// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write ("Введите число до 10:");
int N =  Convert.ToInt32(Console.ReadLine());

string NaturNumber (int start, int end)
{
    if (end == start) return start.ToString();
    return (start + "," + NaturNumber (start - 1, end));

}
Console.WriteLine(NaturNumber(N,1));