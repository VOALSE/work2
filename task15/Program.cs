// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num;
int index = result;

if (num <= 99) Console.WriteLine($"{num} -> третьей цифры нет");
else
{
    while (result > 999)
        result = result / 10;
    result = result % 10;
    Console.WriteLine($"Третья цифра числа {num} -> {result}");
}