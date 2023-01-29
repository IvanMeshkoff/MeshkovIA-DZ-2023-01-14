//Показать последнюю цифру трёхзначного числа

Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "");

int result1 = number % 100;
int result2 = result1 % 10;

Console.WriteLine(result2);