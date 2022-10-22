//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
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
    for (int i = 0; i < Mylist.Count; i++)
    {
        for (int j = 0; j < Mylist[i].Count; j++)
        {
            if (j == k1 * i + b1 && j == k2 * i + b2)
            {
                Console.Write($"Точка пересечения в [{i}] [{j}]");
            }
        }
    }
}


List<List<object>> numbers = new List<List<object>>();
FillList(numbers);

Console.WriteLine("Введите значения для формулы линии: y = k1 * x + b1 ");
Console.Write("k1 =  ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("b1 =  ");
int b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y = k2 * x + b2");
Console.Write("k2 =  ");
int k2 = int.Parse(Console.ReadLine());
Console.Write("b2 =  ");
int b2 = int.Parse(Console.ReadLine());

DrawIntersection(numbers, k1, b1, k2, b2);
Intersection(numbers, k1, b1, k2, b2);



