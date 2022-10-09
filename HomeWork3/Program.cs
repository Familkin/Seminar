// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
int number = new Random().Next(10000, 99999);
Console.WriteLine($"Случайное число: " + number);

int LenghtNumber(int number)
{
    int NumberMemory = number;
    int Length = 0;
    while (NumberMemory != 0)
    {
        NumberMemory = NumberMemory / 10;
        Length++;
    }
    return Length;
}

LenghtNumber(number);
int lenght = LenghtNumber(number);
Console.WriteLine($"Длинна массива: " + lenght);

int[] Array = new int[lenght];
for (int i = lenght - 1; i > -1; i--)
{
    Array[i] = number % 10;
    number = number / 10;
}

int Palindrom(int number1)
{
  int x=1;
}
Palindrom(number);


// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(" " + col[position]);
//         position++;
//     }
// }

// PrintArray(Array);

// Console.WriteLine();
// Console.WriteLine(12345%10);
// Console.WriteLine(12345%10);


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Дополнительно
// 1) Создать программу, которая из массива удаляется элемент с позиции, которую введет пользователь.
// 2) Создание массива из двух массивов. В итоговом массиве должны быть элементы первого и второго массива.
// [1,2,3] [4,5,6] -> [1,2,3,4,5,6]