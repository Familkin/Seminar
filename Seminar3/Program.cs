// //Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// void chetvert(int x, int y)
// {
//     if (x > 0 && y > 0)
//         Console.WriteLine("1 четверть");
//     else if (x > 0 && y < 0)
//         Console.WriteLine("2 четверть");
//     else if (x < 0 && y < 0)
//         Console.WriteLine("3 четверть");
//     else
//         Console.WriteLine("4 четверть");
// }

// string chetvert2(int x, int y)
// {
//     string name = x > 0 && y > 0 ? "1 четверть" : x > 0 && y < 0 ? "2 четверть" : x < 0 && y < 0 ? "3 четверть": "4 четверть";
//     return name;
// }



// int x = int.Parse(Console.ReadLine());
// int y = int.Parse(Console.ReadLine());

// chetvert(x, y);

// string otvet = chetvert2(x, y);
// Console.WriteLine(otvet);


// Задача Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// string kvadrant(int nmb)//4
// {
//     string name = nmb == 1 ? "x > 0 и y > 0" : nmb == 2 ? "x > 0 && y < 0" : nmb == 3 ? "x < 0 && y < 0" : nmb == 4 ? "x > 0 и y < 0" : "Номер не корректен";
//     return name;
// }

// Console.Write("Введите номер квадранта: "); //1
// int X = int.Parse(Console.ReadLine()); //2

// string otvet = kvadrant(X); //3
// Console.WriteLine($"Диапазон значений {X} квадранта: " + otvet);

// Задача 3 Выводит все элементы рандомного массива от -3 до 2 пока не встретится элемент -1
//вводит элементы
//Выводит все элементы
//выводит элементы до -1



// void FillArray(int[] collection)
// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         collection[index] = new Random().Next(-3, 2);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(" "+col[position]);
//         position++;
//     }
// }

// void TillMinusOne(int[] coll)
// {
//     int i = 0;
// while (coll[i]!=-1)
// {
//     Console.Write(" "+coll[i]);
//     i++;
// }
// }

// Console.Clear();
// int K = new Random().Next(10, 30);

// Console.WriteLine($"Размер массива: {K}");
// int[] array = new int[K];
// FillArray(array);

// Console.Write("Основной массив: ");
// PrintArray(array);

// Console.WriteLine();
// Console.Write("Вывод элементов массива до элемента (-1): ");
// TillMinusOne(array);


// Задача 4 Найти сумму всех элементов массива целых чисел, которые меньше среднего арифметического элементов массива. 
// Размерность массива от 10 до 100. Заполнение массива осуществить случайными числами от 150 до 300

// 1. Рандомный размер массива от 10 до 100, с элементами размер каждого случайно от 150 до 300.
// 2. функция: Найти среднее арифметическое в массиве
// 3. функция: Суммируем все элементы меньше среднего арифметического

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(150, 300);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(" "+col[position]);
        position++;
    }
}

int AVG(int[] collection)
{
    int i = 0;
    int sum = 0;
    int AVG = 0;
    while (i < collection.Length)
    {
        sum = sum + collection[i];
        i++;
    }
    AVG = sum / collection.Length;
        return AVG;
}

void SumLessAvg(int[] collection)
{
    int i = 0;
    int SumLessAvg = 0;
    int AVG2 = AVG(collection);
    while (i < collection.Length)
    {
        if (collection[i] < AVG2)
        {
            SumLessAvg = collection[i] + SumLessAvg;
        }
        i++;
        }
    Console.WriteLine($"Сумма всех элементов меньше ср. ар. = {SumLessAvg}");
}

Console.Clear();

int K = new Random().Next(10, 100);
Console.WriteLine($"Размер массива: {K}");

int[] array = new int[K];

FillArray(array);
PrintArray(array);
AVG(array);
Console.WriteLine("");
Console.WriteLine($"Среднее арифметическое: {AVG(array)}");
SumLessAvg(array);
