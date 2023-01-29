//Пример №1. По двум заданным числам проверять является ли первое квадратом второго

Console.Clear();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");

if (number1 == number2 * number2)
{
    Console.Write("Первое число " + number1 + " является квадратом второго числа " + number2 + " ");
}
else 
{
    Console.Write("Первое число " + number1 + " не является квадратом второго числа " + number2 + " ");
}