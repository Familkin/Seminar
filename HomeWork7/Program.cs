/* 

---------------------------Задача 47. 

Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
Console.Clear();

void FillArray(double[,] array, int y, int x)
{
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble()*new Random().Next(-100,100), 1);
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int y = int.Parse(Console.ReadLine());

double[,] array = new double[y, x];
FillArray(array, y, x);
*/








/*
----------------------------------Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

/*
Console.Clear();

void FillArray(int[,] array, int x, int y)
{
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            array[i, j] = new Random().Next(-99, 99);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();

    }
}

void Search(int[,] array, int N)
{

    int countN = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == N)
            {
                countN++;
            }

        }
    }

    if (countN > 0) Console.WriteLine($"Число {N} встречается в массиве {countN} раз");
    else Console.WriteLine("Такого элемента нет в массиве");
}

Console.Write("Введите количество строк: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int y = int.Parse(Console.ReadLine());
int[,] array = new int[x, y];
FillArray(array, x, y);

Console.Write("Введите число, которое ищем в массиве: ");
int N = int.Parse(Console.ReadLine());
Search(array, N);
*/



/*
--------------------------------------Задача 52. 
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

void FillArray(double[,] array, double x, double y)
{
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            array[i, j] = new Random().Next(1, 9);
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

void AvgArray(double[,] array, double y)
{
    int n = 0;


    for (int i = 0; i < array.GetLength(0); i++)
    {
        double summ = 0;
        double avg = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == n)
            {
                summ += array[j, i];
                Console.Write(array[j, i] + "   ");
            }

        }
        n++;
        avg = Math.Round(summ / array.GetLength(1), 2);
        Console.Write(" Среднее арифметическое = "+avg + "   ");
        Console.WriteLine();
    }





}


Console.Write("Введите количество строк: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int y = int.Parse(Console.ReadLine());

double[,] array = new double[x, y];
FillArray(array, x, y);

Console.Write("\nСредние значения по столбцам: ");
Console.WriteLine();

AvgArray(array, y);