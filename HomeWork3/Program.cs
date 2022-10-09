// ----------------------------------------Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
//Решение:

// Console.Clear();

// int number = 12321;
// // int number = new Random().Next(10000, 99999);

// Console.WriteLine($"Случайное пятизначное число: " + number);

// int LenghtNumber(int number)
// {
//     int NumberMemory = number;
//     int Length = 0;
//     while (NumberMemory != 0)
//     {
//         NumberMemory = NumberMemory / 10;
//         Length++;
//     }
//     return Length;
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(" " + col[position]);
//         position++;
//     }
// }

// LenghtNumber(number);

// int[] FillArray()
// {
//     int lenght = LenghtNumber(number);
//     int[] Array = new int[lenght];
//     int NumberCount = number;
//     for (int i = lenght - 1; i > -1; i--)
//     {
//         Array[i] = NumberCount % 10;
//         NumberCount = NumberCount / 10;
//     }
//     return Array;
// }

// int[] myarray = FillArray();

// void Palindrom(int number)
// {
//     int start = 0;
//     int end = myarray.Length - 1;

//     while (start < (myarray.Length - 1) / 2)
//     {
//         if (myarray[start] != myarray[end])
//         {
//             Console.WriteLine($"Число {number} НЕ является палиндром");
//             break;
//         }
//         else
//         {
//             if (start * 2 == (end))
//                 Console.WriteLine($"Число {number} является палиндром");
//         }
//         start++;
//         end--;
//     }

// }

// PrintArray(myarray);
// Palindrom(number);






// ----------------------------------------Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//Решение:
// int[] FillArray()
// {
//     int[] coordinates = new int[3];
//     Console.Write("X: ");
//     coordinates[0] = int.Parse(Console.ReadLine());
//     Console.Write("Y: ");
//     coordinates[1] = int.Parse(Console.ReadLine());
//     Console.Write("Z: ");
//     coordinates[2] = int.Parse(Console.ReadLine());
//     return coordinates;
// }
// Console.Clear();
// Console.WriteLine("Введите координаты первой точки: ");
// int[] coordinates = FillArray();
// Console.WriteLine("Введите координаты второй точки: ");
// int[] coordinates2 = FillArray();
// double distance = Math.Sqrt(Math.Pow(coordinates2[0]-coordinates[0], 2) + Math.Pow(coordinates2[1]-coordinates[1], 2) + Math.Pow(coordinates2[2]-coordinates[2], 2));
// Console.WriteLine("Расстояние между точками= " + distance);

// ----------------------------------------Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
//Решение:

Console.Clear();
Console.Write("Сколько значений из таблицы кубов показать? ");
int X = int.Parse(Console.ReadLine());

double[] cubetable = new double[100];
for (int i = 1; i < X+1; i++)
{
    cubetable[i] = Math.Pow(i,3);
    Console.WriteLine(cubetable[i]);
}

// Дополнительно
// 1) Создать программу, которая из массива удаляется элемент с позиции, которую введет пользователь.
// 2) Создание массива из двух массивов. В итоговом массиве должны быть элементы первого и второго массива.
// [1,2,3] [4,5,6] -> [1,2,3,4,5,6]