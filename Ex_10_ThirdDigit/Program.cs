// Найти третью цифру числа или сообщить, что её нет
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "");

if (number >= 100)
{
  while (number >= 1000)
  {
    number = number / 10;
  }
  int third = number % 10;
  Console.WriteLine($"Третья цифра числа будет = {third}");
}
else
{
  Console.WriteLine($"В числе {number} третьей цифры не существует!");
}