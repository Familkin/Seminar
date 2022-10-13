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
int summ(int number)
{
    int sum=0;
    while (number>0)
    {
        sum= sum+number%10;
        number/=10;
    }
    return sum;
}

Console.Clear();
Console.Write("Веедите число, элементы которого нужно ссумировать: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Сумма цифр в числе = " + summ(num));



