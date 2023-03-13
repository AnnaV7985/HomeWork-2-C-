// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите  число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberI = number;
int sum =0;

while (number >0)
{
    
    sum = sum + number%10;
    number = number / 10;
}


Console.Write($"сумма чисел в числе {numberI} = {sum}");