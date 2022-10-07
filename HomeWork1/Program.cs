// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
//Решение:
// Console.WriteLine("Введите два числа:");
// int number1 = int.Parse(Console.ReadLine());
// int number2 = int.Parse(Console.ReadLine());
// if (number1 > number2)
// {
//     Console.WriteLine($"Максимальное число {number1}");
// }
// else
// {
//     Console.WriteLine($"Максимальное число {number2}");
// }


//-----------------------------------------------------------------------------
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
//Решение:
// Console.WriteLine("Введи три числа: ");
// int number1 = int.Parse(Console.ReadLine());
// int number2 = int.Parse(Console.ReadLine());
// int number3 = int.Parse(Console.ReadLine());
// int max = number1;
// if (number2 > max)
//     max = number2;
// if (number3 > max)
//     max = number3;
// Console.WriteLine($"Максимальное число: {max}");

//-------------------------------------------------------------------------------
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
//Решение:
// Console.Write("Введите число: ");
// int number1 = int.Parse(Console.ReadLine());
// int N = number1 % 2;
// if (N == 0)
// {
//     Console.WriteLine($"Число {number1} четное.");
// }
// else
// {
//     Console.WriteLine($"Число {number1} нечетное.");
// }

//------------------------------------------------------------------------------
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
//Решение:
// Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine());
// int M = 2;
// Console.WriteLine($"Все чётные числа от 1 до {N}: ");
// while (M <= N)
// {
//     Console.WriteLine(M);
//     M = M + 2;
// }






// Задача повышенной сложности
// Напишите программу.
// Какая сумма элементов массива больше – с первого до элемента с номером К или от элемента с номером К+1 до последнего.
// На вход подается массив чисел. Затем вводится переменная K. На выход программа должна вывести или "Первая часть" или "Вторая часть"
// Например, при вводе массива [8 11 15 8 9 10] и числа 3. Программа должна вывести 1 часть, так как 42 больше, чем 19.
//Решение

Console.Write("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());

Console.Write("Рандомные элементы в массиве: ");
int[] array = new int[N]; 
int index = 0; 
while (index < array.Length) 
{
    array[index] = new Random().Next(1,10); 
    Console.Write($"{array[index]},"); 
    Thread.Sleep(10);
    index++;
} 

Console.WriteLine();
Console.WriteLine("Введите порядковый номер элемента в массиве: ");
int K = int.Parse(Console.ReadLine());

//Посчитаем сумму элементов до К и выведем их
int sum1=0;
int i1 = 0;
while (i1<K)
{
    sum1 = array[i1] + sum1;
    i1++;
}
Console.WriteLine($"Сумма элементов до K = {sum1}");

//Посчитаем сумму элементов после К и выведем их
int sum2=0;
int i2 = K;
while (i2<array.Length)
{
    sum2 = array[i2] + sum2;
    i2++;
}
Console.WriteLine($"Сумма элементов после K = {sum2}");

//Сравним значения до к и после
if (sum1>sum2)
{
    Console.WriteLine($"Сумма значений ДО {K} элемента в массиве больше суммы значений после");
}
else 
    Console.WriteLine($"Сумма значений ПОСЛЕ {K} элемента в массиве больше суммы значений До");










// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 10);
//     Console.Write(array[i]);
// }