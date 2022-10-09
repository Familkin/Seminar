﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
//Решение:



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

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(" " + col[position]);
        position++;
    }
}

void FillArray(int[] coll)
{
    int lenght = LenghtNumber(number);
    int NumberCount = number;
    for (int i = lenght - 1; i > -1; i--)
    {
        Array[i] = NumberCount % 10;
        NumberCount = NumberCount / 10;
    }
}

void Palindrom(int number)
{
    int start = 0;
    int end = Array.Length - 1;

    while (start < (Array.Length - 1) / 2)
    {
        if (Array[start] != Array[end])
        {
            Console.WriteLine($"Число {number} НЕ является палиндром");
            break;
        }
        else
        {
            if (start * 2 == (end))
                Console.WriteLine($"Число {number} является палиндром");
        }
        start++;
        end--;
    }

}


Console.Clear();
// int number = 1234321;
int number = new Random().Next(10000, 99999);
Console.WriteLine($"Случайное пятизначное число: " + number);

LenghtNumber(number);
int[] Array = new int[Length];


// FillArray(Array);
// PrintArray(Array);
// Palindrom(Array);




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