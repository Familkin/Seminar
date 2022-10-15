// List

/*
List<int> numbers = new List<int>();
int[] array = new int[10];

array = CreeteMas(10);
numbers.Add(7);
foreach (var n in numbers)
{
    Console.Write(n+" ");
}
*/

//-----------------------------задача 32

//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 
/*
Console.Clear();

int[] FillArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 99);
    }
    return array;
}

int[] Convert(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];
    
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

Console.Write("Введите длинну массива: ");
int len = int.Parse(Console.ReadLine());

int[] array = FillArray(len); 
PrintArray(array); 
Convert(array);
Console.WriteLine();
PrintArray(array); 
*/

//---------------------------Задача 33

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
/*
Console.Clear();

int[] FillArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 99);
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

void control(int[] array)
{
    Console.WriteLine();
    Console.Write("Введите число для поиска: ");
    int N = int.Parse(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == N)
        {
            count++;
        }
    }

    if (count > 0)
    {
        Console.Write($"Да, { count} раз");
    }
    else
    {
        Console.Write("Нет");
    }
}


Console.Write("Введите длинну массива: ");
int len = int.Parse(Console.ReadLine());
int[] array = FillArray(len);
PrintArray(array);
control(array);
*/
/*
Console.Clear();

Console.Write("Введите длинну массива: ");
int len = int.Parse(Console.ReadLine());

List<int> numbers = new List<int>();

int i = 0;
while (i < len)
{
    numbers.Add(new Random().Next(0, 8));
    i++;
}
foreach (var n in numbers)
{
    Console.Write(n + " ");
}
*/



// void control(List<int> array2)
// {
//     Console.WriteLine();
//     Console.Write("Введите число для поиска: ");
//     int N = int.Parse(Console.ReadLine());
//     int count = 0;
//     foreach (var n in array2)
//     {
//         if (n == N)
//         {
//             count++;
//         }
//     }

//     if (count > 0)
//     {
//         Console.Write($"Да, {count} раз");
//     }
//     else
//     {
//         Console.Write("Нет");
//     }
// }

// control(numbers);

//альтернатива
//Console.WriteLine(numbers.Contains(7));


//-----------------------Задача 3

//N кеглей выставили в один ряд, занумеровав их слева направо числами от 1 до N. 

//Затем по этому ряду бросили K шаров, при этом i-й шар сбил все кегли с номерами от li до ri включительно. Определите, какие кегли остались стоять на месте.

//Программа получает на вход количество кеглей N и количество бросков K. Далее идет K пар чисел li, ri, при этом 1≤ li≤ ri≤ N.

//Программа должна вывести последовательность из N символов, где j-й символ есть “I”, если j-я кегля осталась стоять, или “.”, если j-я кегля была сбита.

Console.Clear();

int[] FillArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
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


Console.Write("Введите длинну массива: ");
int len = int.Parse(Console.ReadLine());
int[] array = FillArray(len);
PrintArray(array);

void strike(int ball, int[] array)
{
    while (ball > 0)
    {
        Console.WriteLine("\n С какой по какую кеглю сбили? ");
        int kegliStart = int.Parse(Console.ReadLine());
        int kegliEnd = int.Parse(Console.ReadLine());
        if (kegliStart < 0 || kegliEnd > array.Length || kegliStart > kegliEnd)
        {
            Console.WriteLine("Мимо! Попробуй еще раз!");
            continue;
        }

        for (int i = kegliStart-1; i <= kegliEnd-1; i++)
        {
            array[i] = 0;
        }
        ball--;
        PrintArray(array);
    }

}

Console.Write("\n Сколько шаров будем бросать?: ");
int ball = int.Parse(Console.ReadLine());

strike(ball, array);