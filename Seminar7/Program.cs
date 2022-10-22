/*
void FillList(List <List<double>> Mylist)
{
for (int i = 0; i < 5; i++)
{
    Mylist.Add(new List<double>());
    for (int j = 0; j < 5; j++)
    {
        Mylist[i].Add(Math.Round(new Random().NextDouble()*5));
    }
}
}

void PrintList(List <List<double>> Mylist)
{
for (int i = 0; i < Mylist.Count; i++)
{
    for (int j = 0; j < Mylist[i].Count; j++)
    {
        Console.Write(Mylist[i][j]+" ");
    }
    Console.WriteLine();
}
}

void Zapolnenie(List <List<double>> Mylist)
{
  for (int i = 0; i < Mylist.Count; i++)
{
    for (int j = 0; j < Mylist[i].Count; j++)
    {
        Mylist[i][j]=i+j;
    }
  
}
}

List<List<double>> numbers = new List<List<double>>();

FillList(numbers);
PrintList(numbers);
Zapolnenie(numbers);
Console.WriteLine();
PrintList(numbers);
*/



//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты
/*

void FillArray(List <List<double>> Mylist)
{
for (int i = 0; i < 5; i++)
{
    Mylist.Add(new List<double>());
    for (int j = 0; j < 5; j++)
    {
        Mylist[i].Add(Math.Round(new Random().NextDouble()*5));
    }
}
}


void PrintList(List <List<double>> Mylist)
{
for (int i = 0; i < Mylist.Count; i++)
{
    for (int j = 0; j < Mylist[i].Count; j++)
    {
        Console.Write(Mylist[i][j]+" ");
    }
    Console.WriteLine();
}
}

void Search(List <List<double>> Mylist)
{
  for (int i = 0; i < Mylist.Count; i++)
{
    for (int j = 0; j < Mylist[i].Count; j++)
    {
        if (i%2==0 && j%2==0)
        {
            Mylist[i][j]=Mylist[i][j]*Mylist[i][j];
        }
        
    }
  
}
}


List<List<double>> numbers = new List<List<double>>();

FillArray(numbers);
PrintList(numbers);
Search(numbers);
Console.WriteLine();
PrintList(numbers);

*/


//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1+9+2=12


/*
Console.Clear();

void FillArray(List <List<double>> Mylist)
{
for (int i = 0; i < 4; i++)
{
    Mylist.Add(new List<double>());
    for (int j = 0; j < 4; j++)
    {
        Mylist[i].Add(Math.Round(new Random().NextDouble()*9));
    }
}
}


void PrintList(List <List<double>> Mylist)
{
for (int i = 0; i < Mylist.Count; i++)
{
    for (int j = 0; j < Mylist[i].Count; j++)
    {
        Console.Write(Mylist[i][j]+" ");
    }
    Console.WriteLine();
}
}

void SummDiagonal(List <List<double>> Mylist)
{
    double summ =0;
for (int i = 0; i < Mylist.Count; i++)
{
    for (int j = 0; j < Mylist[i].Count; j++)
    {
        if (i==j)
        {
            summ = summ + Mylist[i][j];
        }
    }
}
Console.WriteLine("Сумма элементов по диагонали равна: " + summ);
}

List<List<double>> numbers = new List<List<double>>();
FillArray(numbers);
PrintList(numbers);
SummDiagonal(numbers);

*/










//Дан двумерный массив и два числа: i и j. 
//Поменяйте в массиве столбцы с номерами i и j и выведите результат.

//Программа получает на вход размеры массива n и m, 
//затем элементы массива, 
//затем числа i и j.

//Решение оформите в виде функции swap_columns(a, i, j).
/*

Console.Clear();

void FillArray(List<List<double>> Mylist, int N, int J)
{
    for (int i = 0; i < N; i++)
    {
        Mylist.Add(new List<double>());
        for (int j = 0; j < J; j++)
        {
            Mylist[i].Add(Math.Round(new Random().NextDouble() * 9));
        }
    }
}


void PrintList(List<List<double>> Mylist)
{
    for (int i = 0; i < Mylist.Count; i++)
    {
        for (int j = 0; j < Mylist[i].Count; j++)
        {
            Console.Write(Mylist[i][j] + " ");
        }
        Console.WriteLine();
    }
}

void change(List<List<double>> Mylist, int I, int J)
{
    double temp = 0;
    for (int i = 0; i < Mylist.Count; i++)
    {
        for (int j = 0; j < Mylist[i].Count; j++)
        {
            temp = Mylist[i][I];
            Mylist[i][I] = Mylist[i][J];
            Mylist[i][J] = temp;
        }
    }

}



List<List<double>> numbers = new List<List<double>>();

Console.WriteLine("Введите количество строк в массиве: ");
int M = int.Parse((Console.ReadLine()));
Console.WriteLine("Введите количество столбцов в массиве: ");
int N = int.Parse((Console.ReadLine()));


FillArray(numbers, N, M);
PrintList(numbers);


Console.WriteLine("Какой столбик меняем?: ");
int I = int.Parse((Console.ReadLine()));
Console.WriteLine("На какой столбик меняем?: ");
int J = int.Parse((Console.ReadLine()));


change(numbers, I, J);
PrintList(numbers);
*/

//Дана матрица целых чисел размером n*m. Выведите количество седловых точек. 
//(Седловой точкой называется элемент, который является наименьшим в своей строке и наибольшим в своем столбце или, наоборот, 
//наибольшим в своей строке и наименьшим в своем столбце).


Console.Clear();

void FillArray(List<List<double>> Mylist, int N, int J)
{
    for (int i = 0; i < N; i++)
    {
        Mylist.Add(new List<double>());
        for (int j = 0; j < J; j++)
        {
            Mylist[i].Add(Math.Round(new Random().NextDouble() * 9));
        }
    }
}


void PrintList(List<List<double>> Mylist)
{
    for (int i = 0; i < Mylist.Count; i++)
    {
        for (int j = 0; j < Mylist[i].Count; j++)
        {
            Console.Write(Mylist[i][j] + " ");
        }
        Console.WriteLine();
    }
}

void Search(List<List<double>> Mylist)
{

    List<double> minrow = new List<double>();


    for (int i = 0; i < Mylist.Count; i++)
    {
        minrow.Add(Mylist[i][0]);
        for (int j = 0; j < Mylist[i].Count; j++)
        {
            if (Mylist[i][j] < minrow[i])
            {
                minrow[i] = Mylist[i][j];
            }

        }
        Console.Write("min: " +minrow[i]);
    }

Console.WriteLine();

    List<double> maxcol = new List<double>();
    for (int j = 0; j < Mylist.Count; j++)
    {
        maxcol.Add(Mylist[0][j]);
        for (int i = 0; i < Mylist[j].Count; i++)
        {
            if (Mylist[i][j] > maxcol[j])
            {
                maxcol[j] = Mylist[i][j];

            }

        }
        Console.Write("max: " +maxcol[j]);
    }

// 2 цикла сравнить если элементы равны то увеличиваем счетчик
}






List<List<double>> numbers = new List<List<double>>();

Console.WriteLine("Введите количество строк в массиве: ");
int M = int.Parse((Console.ReadLine()));
Console.WriteLine("Введите количество столбцов в массиве: ");
int N = int.Parse((Console.ReadLine()));


FillArray(numbers, N, M);
PrintList(numbers);
Console.WriteLine();
Search(numbers);