﻿/*
Напишите программу, которая выводит третью цифру ПЯТИЗНАЧНОГО числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int value = (number/ 100) % 10;
if  (value > 0)
{

Console.WriteLine($"третья цифра в введенном числе {value}");

}
else
{
  Console.WriteLine($"Число не пятизначное, нет третьего числа");  
}
