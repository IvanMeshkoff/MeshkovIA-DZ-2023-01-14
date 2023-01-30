// Удалить вторую цифру трёхзначного числа

// Вариант №1:

Console.Clear();
Console.WriteLine("Вариант №1: ");
Console.Write($"Введите трёхзначное число: ");
int number1 = int.Parse(Console.ReadLine() ?? "");
string c = Convert.ToString(number1);

Console.WriteLine($"После удаления второй цифры число примет вид = {c[0]}{c[2]}");
Console.WriteLine();

// Вариант №2:

Console.WriteLine("Вариант №2: ");
int number2 = new Random().Next(100, 1000);
Console.WriteLine($"Дано произвольное трёхзначное число: {number2}");

int a = number2 / 100;
int b = number2 % 10;

Console.WriteLine($"После удаления второй цифры число примет вид = {a}{b}");

//int result1 = a + b;

//Console.WriteLine($"После удаления второй цифры число будет = {result1}");