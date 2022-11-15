// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int rows = 4;
// int columns = 4;
// int[,] matrix = new int [rows, columns];

// Console.WriteLine("Задайте массив!");
// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int [rows, columns];

// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(-10, 10);
//         Console.Write(matrix[i, j]+ "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Новый массив: ");

// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         for(int k=0; k < matrix.GetLength(1) - 1; k++)
//         {
//             if (matrix[i, k] < matrix[i, k + 1])
//             {
//                 int count = matrix[i, k];
//                 matrix[i, k] = matrix[i, k + 1];
//                 matrix[i, k + 1] = count;
//             }
//         }
//         Console.Write(matrix[i, j]+ "\t");
//     }
//     Console.WriteLine();
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Задайте массив!");
// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int [rows, columns];
// int temp = int.MaxValue;
// int sum = 0;
// int k = 0;


// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(-10, 10);
//         Console.Write(matrix[i, j]+ "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// for(int i=0; i<matrix.GetLength(0); i++)
// {
//     sum = 0;
//     for(int j=0; j<matrix.GetLength(1); j++)
//     {
//         sum += matrix[i, j];
//     }
//     Console.WriteLine($"Сумма элементов строки {i+1}: {sum}");
//     if (temp > sum)
//     {
//         temp = sum;
//         k = i;
//     }
// }
// Console.WriteLine($"Номер строки с наименьшей суммой элементов: {k+1}");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// Console.WriteLine("Задайте первую матрицу!");
// Console.Write("Введите кол-во строк: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int columns1 = Convert.ToInt32(Console.ReadLine());

// int rows2 = columns1;
// int colums2 = rows1;

// int[,] matrix1 = new int [rows1, columns1];

// for(int i=0; i<matrix1.GetLength(0); i++)
// {
//     for(int j=0; j<matrix1.GetLength(1); j++)
//     {
//         matrix1[i, j] = new Random().Next(-10, 10);
//         Console.Write(matrix1[i, j]+ "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// Console.WriteLine("Вторая матрица:");
// int[,] matrix2 = new int [rows2, colums2];

// for(int i=0; i<matrix1.GetLength(0); i++)
// {
//     for(int j=0; j<matrix2.GetLength(1); j++)
//     {
//         matrix2[i, j] = new Random().Next(-10, 10);
//         Console.Write(matrix2[i, j]+ "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// Console.WriteLine("Произведение матриц:"); 

// int [,] matrixAnsver = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

// for(int i=0; i<matrix1.GetLength(0); i++)
// {
//     for(int j=0; j<matrix2.GetLength(1); j++)
//     {   
//         for(int k=0; k<matrix2.GetLength(0); k++)
//         {
//             matrixAnsver[i, j] += matrix1[i, k] * matrix2[k, j];
//         }
//         Console.Write(matrixAnsver[i, j]+ "\t");
//     }
//     Console.WriteLine();
// }



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.Write("Введите кол-во строк (X): ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов (Y): ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность по оси Z: ");
// int zElements = Convert.ToInt32(Console.ReadLine());

// if (rows*columns*zElements>90) Console.WriteLine("Недостаточно уникальных двузнач. чисел для заполнения!");

// else
// {
//     int count = 0;
//     int [] arrayRandom = new int[90];
//     for (int i = 0; i < arrayRandom.Length - 1; i++) arrayRandom[i] = 10 + i;
//     for (int i = 0; i < arrayRandom.Length; i++)
//     {
//         int j = new Random().Next(arrayRandom.Length);
//         int temp = arrayRandom[j];
//         arrayRandom[j] = arrayRandom[i];
//         arrayRandom[i] = temp;
//     }



//     int[,,] array = new int [rows, columns, zElements];

//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//         {   
//             for(int k=0; k<array.GetLength(2); k++)
//             {
//                 array[i, j, k] = arrayRandom[count];
//                 Console.Write($"{array[i, j, k]}({i},{j},{k})");
//                 count++;
//             }
//             Console.WriteLine();
//         }
        
//     }
// }




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int [4, 4];

int count = 0;
int i = 0;
int j = 0;

for ( j=0; j<array.GetLength(1); j++)
{
    array[i, j] = 1 + count;
    count++;
}

j = 3;
for ( i=1; i<array.GetLength(0); i++)
{
    array[i, j] = 1 + count;
    count++;
}

i = 3;
for ( j=2; j>=0; j-=1)
{
    array[i, j] = 1 + count;
    count++;
}

j = 0;
for ( i=2; i>=1; i-=1)
{
    array[i, j] = 1 + count;
    count++;
}

i = 1;
for ( j=1; j<=2; j++)
{
    array[i, j] = 1 + count;
    count++;
}

i = 2;
for ( j=2; j>=1; j-=1)
{
    array[i, j] = 1 + count;
    count++;
}

for ( i=0; i<array.GetLength(0); i++)
{
    for ( j=0; j<array.GetLength(1); j++) Console.Write(array[i, j]+ "\t");
    Console.WriteLine();
}
Console.WriteLine(" ");