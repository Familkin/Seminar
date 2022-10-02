// //Задача 1
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine($"Квадрат {number} равен {number*number}");

// string name = Console.ReadLine(); //Ввод имени
// Console.WriteLine("Ваше имя: "+name); // Вывод имени

//Задача 2. Является ли первое число квадратом второго?
// int num1 = int.Parse(Console.ReadLine());
// int num2 = int.Parse(Console.ReadLine());
// if (num2*num2==num1)
// {
//     Console.WriteLine($"{num1} Квадрат от {num2}");
// }
// else
// {
//     Console.WriteLine($"Нет не является");
// }


//Задача 3 Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine());
Console.Write("Этот день недели: ");
if (number == 1)
    Console.WriteLine("Понедельник");
else 
if (number == 2)
    Console.WriteLine("Вторник");
else 
if (number == 3)
    Console.WriteLine("Среда");
else 
if (number == 4)
    Console.WriteLine("Четверг");
else 
if (number == 5)
    Console.WriteLine("Пятница");
else 
if (number == 6)
    Console.WriteLine("Суббота");
else 
if (number == 7)
    Console.WriteLine("Воскресенье");