
/*
Console.Clear();
void FillMas(int[,] arr)
{
    for (int i = 0; i < 5; i++)
        for (int j = 0; j < 5; j++)
            arr[i, j] = new Random().Next(2, 10);
}
void PrintMas(int[,] arr)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
            Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();

}
int[,] Swap(int[,] arr)
{
    int lastindex = arr.GetLength(0) - 1;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int temp = arr[0, j];
        arr[0, j] = arr[lastindex, j];
        arr[lastindex, j] = temp;
    }
    return arr;
}



int[,] array = new int[5, 5];
FillMas(array);
PrintMas(array);
int[,] newArr = new int[5, 5];
newArr = Swap(array);

PrintMas(newArr);
*/


//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
Console.Clear();

void FillMas(int[,] arr)
{
    for (int i = 0; i < 5; i++)
        for (int j = 0; j < 5; j++)
            arr[i, j] = new Random().Next(2, 10);
}
void PrintMas(int[,] arr)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
            Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] Chenge(int[,] arr)
{
    int[,] rArr = new int[arr.GetLength(1),arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            rArr[j, i] = arr[i, j];
        }
    return rArr;
}

int[,] array = new int[5, 5];
FillMas(array);
PrintMas(array);
int[,] newArr = new int[5, 5];
newArr = Chenge(array);
PrintMas(newArr);
*/


//Посчитать сколько раз встречается каждый элемент в массиве

Console.Clear();

void FillMas(int[,] arr)
{
    for (int i = 0; i < 5; i++)
        for (int j = 0; j < 5; j++)
            arr[i, j] = new Random().Next(2, 10);
}
void PrintMas(int[,] arr)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
            Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] ArrinOne(int[,] arr)
{
    int[] ArrayOne = new int[arr.GetLength(0) * arr.GetLength(1)];
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            ArrayOne[k] = arr[i, j];
            k++;
        }
    }
    foreach (var el in ArrayOne)
    {
        Console.Write(el + " ");
    }
    return ArrayOne;
    Console.WriteLine();
}

int[] SortOne(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
    return arr;
}

// void PrintCountNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {

//         while (array[i + 1] == array[i])
//         {
//             count++;
//         }
//         Console.WriteLine("Элемент встречается" + count + " раз");
//     }
// }

void FillDictionary(int[,] array)
{
    Dictionary<int, int> numbers = new Dictionary<int, int>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (numbers.ContainsKey(array[i, j]))
            {
                numbers[array[i,j]]+=1;
            }
            else
            {
                numbers.Add(array[i,j],1);
            }
        }
    }
    foreach (var num in numbers)
    {
        Console.WriteLine($"Число {num.Key} встретилось {num.Value}");
    }
}

int[,] array = new int[5, 5];
FillMas(array);
PrintMas(array);
int[] ArrayOne = ArrinOne(array);
Console.WriteLine();

int[] sortArray = SortOne(ArrayOne);
// PrintCountNumbers(sortArray);
FillDictionary(array);