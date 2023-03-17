// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
// Второй вариант решения:
// double pointX = 0;
// double pointY = 0; 
// double x = pointX;
// pointY = k1 * x + b1;
// pointY = k2 * x + b2;
// pointX = (b2-b1)/(k1-k2);
// pointY = k1*((b2-b1)/(k1-k2))+b1;

 double pointX = (b2-b1)/(k1-k2);
 double pointY = k1*((b2-b1)/(k1-k2))+b1;


Console.WriteLine ($"Точка пересечения двух прямых: ({pointX};{pointY})");
