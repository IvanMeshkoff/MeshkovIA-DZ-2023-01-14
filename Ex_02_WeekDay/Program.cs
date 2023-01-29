//Пример №2. По заданному номеру дня недели вывести его название

Console.Clear();
Console.Write("Введите номер дня недели: ");
int dayOfweek = int.Parse(Console.ReadLine() ?? "0");

if (dayOfweek == 1)
{
    Console.Write("Понедельник");
}
else if (dayOfweek == 2)
{
    Console.Write("Вторник");
}
else if (dayOfweek == 3)
{
    Console.Write("Среда");
}
else if (dayOfweek == 4)
{
    Console.Write("Четверг");
}
else if (dayOfweek == 5)
{
    Console.Write("Пятница");
}
else if (dayOfweek == 6)
{
    Console.Write("Суббота");
}
else if (dayOfweek == 7)
{
    Console.Write("Воскресенье");
}
else
{
    Console.Write("Такого дня недели не существует!");
}