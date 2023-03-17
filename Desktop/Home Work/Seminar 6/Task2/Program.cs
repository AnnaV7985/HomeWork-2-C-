// // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] WriteArray = NewArray(10);
Console.WriteLine ($"[{String.Join(";", WriteArray)}] ");


int[] NewArray (int size)
{
    Console.WriteLine ($" Укажи размер масссива не больше 10:");
    size = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];
    Console.WriteLine ($"Введите числа от -5 до 5: ");

    int countPositiv = 0;

    for (int i = 0; i < size; i++)
        {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i]>0)  
            {
                countPositiv++ ;
            }
           
        }
    Console.WriteLine($"в массиве введено {countPositiv} положительных чисел");
    return array;          
    
}







