//--------------------------------------------Задача 25: 

//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Сделать в функции, сделать проверку на отрицательность.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
Console.Clear();

void exponentiation(int a, int b)
{
    double c = Math.Pow(a, b);
    Console.WriteLine("Результат возведения степень = " + c);

}

int controll(int a, int b)
{
    int count = 0;
    if (b <= 0)
    {
        while (b <= 0)
        {
            Console.Write("Это не натуральное число, попробуй снова: ");
            b = int.Parse(Console.ReadLine());
        }
        exponentiation(a, b);

    }
    else
    {
        exponentiation(a, b);
    }
    return b;
}

Console.Write("Введите чиссло которое нужно возвести в степень: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите натуральную степень в которое нужно возвести число: ");
int b = int.Parse(Console.ReadLine());

controll(a,b);
*/

// ------------------------------------------Задача 27: 

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


/* // тупиковый вариант
Console.Clear();

int summ(int N)
{
    string str1 = $"{N}";
    int summ = 0;
    int i = 0;

    while (i < str1.Length)
    {
        summ = summ + Convert.ToInt32(str1[i]);
        i++;
    }

    Console.WriteLine(summ);

    return summ;
}

Console.Write("Веедите число, элементы которого нужно ссумировать");
int N = int.Parse(Console.ReadLine());
summ(N);
*/


// рабочий вариант
// int summ(int number)
// {
//     int sum=0;
//     while (number>0)
//     {
//         sum= sum+number%10;
//         number/=10;
//     }
//     return sum;
// }

// Console.Clear();
// Console.Write("Веедите число, элементы которого нужно ссумировать: ");
// int num = int.Parse(Console.ReadLine());
// Console.Write("Сумма цифр в числе = " + summ(num));

//Задача 29: 
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//Элементы задаются рандомно. 
//Итоговый массив должен содержать в себе суммы цифр числа. 
//Т.е. необходимо подсчитывать суммы цифр чисел и записывать их в новый массив.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//63, 12, 33, 36 -> [9, 3, 6, 9]

Console.Clear();

int[] FillArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 99);
    }
    return array;
}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] SummElementArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int sum = 0;
        while (array[i] > 0)
        {
            sum = sum + array[i] % 10;
            array[i] /= 10;
        }
        Console.Write(sum + " ");
    }
    return array;
}


Console.Write("Введите длинну массива: ");
int len = int.Parse(Console.ReadLine());
int[] array = FillArray(len);
Console.Write("Рандомный массив: ");
PrintArray(array);
Console.WriteLine();
Console.Write("Сумма цифр каждого элемента в рандомном массиве: ");
SummElementArray(array);