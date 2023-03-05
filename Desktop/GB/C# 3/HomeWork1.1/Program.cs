/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Write("Введите пятизначное число : ");
int number = Convert.ToInt32(Console.ReadLine());
int firstNumber = number/10000;
int lastNumber = number % 10;
int secondNumber = (number / 1000)%10;
int fourNumber = (number / 10)%10;

if (firstNumber == lastNumber && secondNumber == fourNumber )
{
    Console.WriteLine ($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine ($"Число {number} не является палиндромом");
}





