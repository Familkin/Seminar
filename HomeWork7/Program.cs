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

