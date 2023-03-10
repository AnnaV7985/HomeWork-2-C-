// сумма чисел от 1 до А
/*Console.Write("Введите  число : ");
int N = Convert.ToInt32(Console.ReadLine());
int sum =0; 

for (int i = 1; i < N; i++) sum= sum + i;
{
    N = N + sum;
    Console.WriteLine($"Сумма чисел = {N}:");
}


2. определить кол-во цифр в числе:
  
*/

Console.Write("Введите  число : ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (N > 1)
{
    N = N%10;
    
    N = N/10; 
   count++ ;
   
}
 Console.WriteLine(count);