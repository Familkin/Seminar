//--------------------------Задача 1 
//принимает А выдает сумму от 1 до А
// int A = int.Parse(Console.ReadLine());

// int sum = 0;
// for (int i = 0; i < A; i++)
// {
//     sum += i;
// }

// Console.WriteLine($"Сумма равна {sum}");



//-------------------------Задача 2
//Задан список фамилий брокеров товарной биржи из N человек. 
//Обменяйте местами фамилии брокеров: первого и последнего, второго и предпоследнего, третьего от начала и третьего от конца и т.д.
//Например, Олег Вася Камила Дора -> Дора Камила Вася Олег

/*
string[] FillNames(int length)
{
    string[] arr = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine("Введите имя:");
        arr[i] = Console.ReadLine();
        Console.WriteLine();
    }
    return arr;

}

void Printarray(string[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}

string[] arr = FillNames(3);
Printarray(arr);

string [] inverse (string[] arr)
{
string temp = "";
int length = arr.Length;
for (int i = 0; i < length/2; i++)
{
    temp = arr[length-i-1];
    arr[length-i-1]=arr[i];
    arr[i]=temp;
}
return arr;
}
Printarray(inverse(arr));
*/

//---------------- задача 3 
//Дан одномерный массив целых чисел. Найдите, сколько раз в нем повторяется самое частое число.
//Например,  15      23      14      23      17      23      21      14 -> 3



/*

int[] FillArray()
{
    int[] arr = new int[20];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

int[] arr = FillArray();

void Printarray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}

Printarray(arr);

void count(int[] array)
{
        int count = 0;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == array[j + 1])
        {
            count++;
        }
    }
Console.WriteLine();
Console.WriteLine($"Число встречается"+count);
}

count(arr);

*/


// задача 4
//Программа должна создать массив из 12 случайных целых чисел из отрезка [-10;10] таким образом, 
//чтобы отрицательных и положительных элементов там было поровну и не было нулей. 
//При этом порядок следования элементов должен быть случаен 
//(т. е. не подходит вариант, когда в массиве постоянно выпадает сначала 6 положительных, а потом 6 отрицательных 
//чисел или же когда элементы постоянно чередуются через один и пр.). Вывести полученный массив на экран.

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
        if (N < 0) countMinus++;
        if (N > 0) countPlus++;
        if (countMinus == 6) int N = new Random().Next(-10, 1);
        if (countPlus == 6)  int N = new Random().Next(-10, 1);
if (N!=0) 

        arr[i] = N; i++;

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

int[] arr = FillArray();
Printarray(arr);
*/
//задача 5
//Преобразовать массив так, чтобы сначала шли нулевые элементы, а затем все остальные.
//-1 -3 -1 -3 -1 0 -4 -2 -> 0 -3 -1 -3 -1 -1 -4 -2

int[] FillArray()
{
    int[] arr = new int[20];
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


int[] array = FillArray();
Printarray(array);
SelectionSort(array);
Printarray(array);