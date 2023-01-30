// Выяснить, кратно ли число заданному, если нет, вывести остаток

// Вариант №1:

Console.Clear();
Console.WriteLine("Вариант №1:");
Console.Write("Задайте число, на которое будет проверяться кратность: ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число, которое будет проверяться на кратность заданному: ");
int b = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine();
if (b % a == 0)
{
    Console.WriteLine($"Введенное число {b} кратно заданному числу {a}");
}
else 
{
    int c = b % a;
    Console.WriteLine($"Введенное число {b} НЕ кратно заданному числу {a}");
    Console.WriteLine($"Остаток от деления будет = {c}");
}
Console.WriteLine();

// Вариант №2:

Console.WriteLine("Вариант №2:");
Console.Write("Задайте число, на которое будет проверяться кратность: ");
int number1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число, которое будет проверяться на кратность заданному: ");
int number2 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine();
int mod = number2 % number1;
if (mod == 0)
{
    Console.WriteLine($"Введенное число {number2} кратно заданному числу {number1}");
}
else 
{
    Console.WriteLine($"Введенное число {number2} НЕ кратно заданному числу {number1}");
    Console.WriteLine($"Остаток от деления будет = {mod}");
}