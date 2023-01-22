//Пример №1. По двум заданным числам проверять является ли первое квадратом второго

Console.Clear();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");

if (number1 == number2 * number2)
{
    Console.Write("Число " + number1 + " является квадратом числа " + number2 + " ");
}
else 
{
    Console.Write("Число " + number1 + " не является квадратом числа " + number2 + " ");
}