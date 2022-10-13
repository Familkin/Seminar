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

// Console.Clear();

// int[] FillArray(int len)
// {
//     int[] array = new int[len];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 99);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int[] SummElementArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int sum = 0;
//         while (array[i] > 0)
//         {
//             sum = sum + array[i] % 10;
//             array[i] /= 10;
//         }
//         Console.Write(sum + " ");
//     }
//     return array;
// }


// Console.Write("Введите длинну массива: ");
// int len = int.Parse(Console.ReadLine());
// int[] array = FillArray(len);
// Console.Write("Рандомный массив: ");
// PrintArray(array);
// Console.WriteLine();
// Console.Write("Сумма цифр каждого элемента в рандомном массиве: ");
// SummElementArray(array);


//Дополнительно
//1) Преобразовать массив так, чтобы сначала шли нулевые элементы, а затем все остальные.
//-1 -3 -1 -3 -1 0 -4 -2 -> 0 -3 -1 -3 -1 -1 -4 -2
/*
int[] FillArray(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-2, 10);
    }
    return arr;
}

void Printarray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int j = 0;
        int temp = 0;
        if (array[i] == 0)
        {
            if (array[j] != 0)
            {
                temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }

            else
            {
                j++;
                temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}

Console.Clear();

Console.Write("Введите длинну массива (чем больше массив, тем верочтнее выпадение нулей =)): ");
int len = int.Parse(Console.ReadLine());

int[] array = FillArray(len);
Printarray(array);
SelectionSort(array);
Printarray(array);
*/









//2) Программа должна создать массив из 12 случайных целых чисел из отрезка [-10;10] таким образом, чтобы отрицательных и положительных элементов там было поровну и не было нулей. При этом порядок следования элементов должен быть случаен (т. е. не подходит вариант, когда в массиве постоянно выпадает сначала 6 положительных, а потом 6 отрицательных чисел или же когда элементы постоянно чередуются через один и пр.). Вывести полученный массив на экран.
/*
int[] FillArray()
{
    int countPlus = 0;
    int countMinus = 0;
    int[] arr = new int[12];
    int i = 0;
    while (i < arr.Length)
    {
        int N = new Random().Next(-10, 10);
        if (N == 0) continue;
        if (countMinus == 6) N = new Random().Next(1, 10);
        if (countPlus == 6) N = new Random().Next(-10, 1);
        arr[i] = N; i++;
        if (N < 0) countMinus++;
        if (N > 0) countPlus++;
    }
    Console.WriteLine($"Отрицательных чисел " + countMinus);
    Console.WriteLine($"Положительных чисел " + countPlus);
    return arr;
}

void Printarray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}

Console.Clear();
int[] arr = FillArray();
Printarray(arr);
*/




//3) Решить задачу
//Известно, что на доске 8×8 можно расставить 8 ферзей так, чтобы они не били друг друга. Вам дана расстановка 8 ферзей на доске, определите, есть ли среди них пара бьющих друг друга.
//Программа получает на вход восемь пар чисел, каждое число от 1 до 8 — координаты 8 ферзей. Если ферзи не бьют друг друга, выведите слово NO, иначе выведите YES.