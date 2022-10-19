//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
Console.Clear();
int[] FillArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 999);
        Console.Write(array[i] + " ");
    }

    return array;
}
void CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }


    }

Console.WriteLine($"\n Количество четных чисел в массиве: {count}");

}

Console.Write("Введите длинну массива: ");
int len = int.Parse(Console.ReadLine());

int[] array = FillArray(len);

CountPositive(array);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
Console.Clear();
int[] FillArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(-99, 99);
        Console.Write(array[i] + " ");
    }

    return array;
}

void Summ(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summ = summ + array[i];
    }
    Console.WriteLine("\n Сумма элементов на не четных позициях: " + summ);

}

Console.Write("Введите длинну массива: ");
int len = int.Parse(Console.ReadLine());

Summ(FillArray(len));
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
Console.Clear();
int[] FillArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(1, 99);
        Console.Write(array[i] + " ");
    }

    return array;
}

void Difference(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    System.Console.WriteLine("\nМинимальное значение: " + min);
    System.Console.WriteLine("Максимальное значение: " + max);
    System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {max - min}");
}

Console.Write("Введите длинну массива: ");
int len = int.Parse(Console.ReadLine());

Difference(FillArray(len));
*/

//Дополнительно
//Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. Обновите список только при первом вхождении числа 20.
//[21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20]

Console.Clear();

int[] FillArray(int len)
{
    int[] array = new int[len];

    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(1, 10);
        // Console.Write(array[i] + " ");
    }
    return array;
}


Console.Write("\nВведите длинну массива: ");
int len = int.Parse(Console.ReadLine());
List<int> numbers = new List<int>();
int[] array = new int[len];
array = FillArray(len);
numbers.AddRange(array);

foreach (var n in numbers)
{
    Console.Write(n + " ");
}

Console.Write("\nКакое число меняем?:  ");
int N = int.Parse(Console.ReadLine());
Console.Write("\nНа какое число меняем?:  ");
int M = int.Parse(Console.ReadLine());

List<int> Search(List<int> List, int N, int M)
{
    for (int i = 0; i < List.Count; i++)
    {
        if (List[i] == N)
        {
            List[i] = M;
        }
        break;
    }
    return List;
}

numbers.AddRange(Search(numbers, N, M));

foreach (var n in numbers)
{
    Console.Write(n + " ");
}