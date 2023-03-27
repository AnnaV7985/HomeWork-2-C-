//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



Console.Write ("Введите  число m: ");
int mNumber1 =  Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите  число n: ");
int nNumber2 =  Convert.ToInt32(Console.ReadLine());

int AckermannFunction (int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    } 
    else if (m == 0)
    {
        return AckermannFunction (n - 1,1);
    }
  else 
  {
    return AckermannFunction (n - 1, AckermannFunction (n, m - 1));
  }
}
    Console.WriteLine($"A(m,n) = {AckermannFunction(mNumber1,nNumber2)} ");

       
 

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))