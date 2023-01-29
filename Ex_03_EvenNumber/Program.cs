// Выяснить является ли число чётным
// Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "");
if (number % 2 == 0)
{
    Console.WriteLine("Число " + number + " является ЧЕТНЫМ!");
}
else
{
    Console.WriteLine("Число {0} является НЕЧЕТНЫМ!", number);
}