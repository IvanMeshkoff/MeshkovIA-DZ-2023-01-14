// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// Вариант №1:

Console.Clear();
int number1 = new Random().Next(10, 100);
string a = Convert.ToString(number1);
Console.WriteLine($"Дано произвольное число: {number1}");

if (a[0]>a[1])
{
    Console.WriteLine($"Наибольшая цифра числа будет равна: {a[0]}");
}
else
{
    Console.WriteLine($"Наибольшая цифра числа будет равна: {a[1]}");
}
Console.WriteLine();

// Вариант №2:

int number2 = new Random().Next(10, 100);
Console.WriteLine($"Дано произвольное число: {number2}");

int a1 = number2 / 10;
int a2 = number2 % 10;

if (a1>a2)
{
    Console.WriteLine($"Наибольшая цифра числа будет равна: {a1}");
}
else
{
    Console.WriteLine($"Наибольшая цифра числа будет равна: {a2}");
}