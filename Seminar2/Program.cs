//Задача 1


// int num = new Random().Next(10,99); 
// int s1 = num/10;
// int s2 = num%10;

// Console.WriteLine(num);
// Console.WriteLine(s1+" "+s2);

// if (s1>s2)
// {
//     Console.WriteLine($"Максимальное число {s1}");
// }
// else 
// Console.WriteLine($"Максимальное число {s2}");


// Задача 2 Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.

int num = new Random().Next(10, 9999);
string num2 = Convert.ToString(num);
char[] MassivStrok = num2.ToCharArray();
int len = num2.Length;
// string[] MassivStrok = new string num2[len];
Console.WriteLine($"Массив: {num}");
Console.WriteLine($"Массив в строке: {num2}");
Console.WriteLine($"Количество цифр: {len}");

int max = 0;

foreach (char item in num2)
{
    int k = (int)Char.GetNumericValue(item);
    if (max < k)
    {
        max = k;
    }

}
Console.WriteLine($"Максимальное число: {max}");

