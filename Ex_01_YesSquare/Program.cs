//Пример №1. По двум заданным числам проверять является ли первое квадратом второго

Console.Clear();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");

if (number1 == number2 * number2)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else 
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}