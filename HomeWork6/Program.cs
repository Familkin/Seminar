//-----------------------------------------------Задача 41:
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
Console.Clear();
Console.WriteLine("Сколько чисел будем вводить?: ");
int N = int.Parse(Console.ReadLine());
int count=0;
int i=0;
while (i<N)
{
    Console.WriteLine("Введите Число?: ");
    int M = int.Parse(Console.ReadLine());
    if (M>0)
    {
        count++;
    }
    i++;
}
Console.WriteLine($"Вы ввели {count} чисел больше нуля. ");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, 
//y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)









/*                                               //Тупиковое решение. Система координат не учитывает отрицательные значения
Console.Clear();

void FillList(List<List<object>> Mylist)
{
    for (int i = 0; i < 20; i++)
    {
        Mylist.Add(new List<object>());
        for (int j = 0; j < 100; j++)
        {
            Mylist[i].Add("*");
        }
    }
}

void DrawIntersection(List<List<object>> Mylist, int k1, int b1, int k2, int b2)
{
    for (int i = 0; i < Mylist.Count; i++)
    {
        for (int j = 0; j < Mylist[i].Count; j++)
        {
            if (j == k1 * i + b1 && j == k2 * i + b2) Console.Write("!");
            if (j == k1 * i + b1 || j == k2 * i + b2) Console.Write("*");
            else Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void Intersection(List<List<object>> Mylist, int k1, int b1, int k2, int b2)
{
    double x = (b2 - b1) / (k1-k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Координаты точки пересечения {x} , {y}");
}


List<List<object>> numbers = new List<List<object>>();

FillList(numbers);

Console.WriteLine("Введите значения для формулы линии: y = k1 * x + b1 ");
Console.Write("k1 =  ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("b1 =  ");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите y = k2 * x + b2");
Console.Write("k2 =  ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("b2 =  ");
double b2 = double.Parse(Console.ReadLine());

// DrawIntersection(numbers, k1, b1, k2, b2);
// Intersection(numbers, k1, b1, k2, b2);
*/








//-------------------------------------------------------------------Рабочее решение 43 задачи
/*
Console.Clear();

Console.WriteLine("Введите значения для формулы линии: y = k1 * x + b1 ");
Console.Write("k1 =  ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("b1 =  ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y = k2 * x + b2");
Console.Write("k2 =  ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("b2 =  ");
double b2 = double.Parse(Console.ReadLine());

void DrawIntersection (double k1, double b1, double k2, double b2) // если координаты пересечения дробные, то не отмечает точку пересечения =(
{
k1 = (int)k1; b1 = (int)b1; k2 = (int)k2; b2 = (int)b2;

for (int i = -7; i < 7; i++)
{
    for (int j = -50; j < 50; j++)
    {
        if (j == k1 * i + b1 && j == k2 * i + b2) Console.Write("!");
        if (j == k1 * i + b1 || j == k2 * i + b2) Console.Write("*");
        else Console.Write(" ");
    }
    Console.WriteLine();
}
}

void Intersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1-k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Координаты точки пересечения {x} , {y}");
}

DrawIntersection (k1, b1, k2, b2);
Intersection(k1, b1, k2, b2);
*/







//-----------------------------------------------Доп задача 2 
//Дано действительное положительное число a и целое неотрицательное число n. 
//Вычислите an не используя циклы, возведение в степень через ** и функцию math.pow(), а используя рекуррентное соотношение an=a⋅an-1.
/*
Console.Clear();

int pow(int A, int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return A * pow(A, n - 1);
    }

}

Console.WriteLine("Для решения уровнения А^n:");
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(pow(A, n));

*/










//---------------------------------------------------------------------доп задача 4
//Заполнить двумерный массив следующим образом.
//Вводится число n.
// 1 1 1 . 1 
// 1 2 2 . 2
// 1 2 3 . 3
// . . . . .
// 1 2 3 . n

Console.Clear();

void FillArray(int[,] array, int n, int N)
{
    if (n < N)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == n || j == n) array[i, j] = n + 1;
            }
        }
        n++;
        FillArray(array, n, N);
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());
int[,] array = new int[N, N];
int n = 0;

FillArray(array, n, N);
PrintArray(array);