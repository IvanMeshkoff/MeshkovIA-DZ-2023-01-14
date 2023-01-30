// Показать вторую цифру трёхзначного числа

// Вариант №1:

Console.Clear();
Console.Write("Введите трехзначное число: ");

string number1 = Console.ReadLine() ?? "";
Console.WriteLine("Вторая цифра этого трехзначного числа будет = " + number1[1]);
Console.WriteLine();

// Вариант №2:

Console.Write("Введите трехзначное число: ");
int number2 = int.Parse(Console.ReadLine() ?? "");


while (number2 >= 100)
{
    number2 /= 10;
}
number2 = number2 % 10;
Console.WriteLine($"Вторая цифра этого трехзначного числа будет = {number2}");