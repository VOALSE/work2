// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Введите день недели: ");
int week = Convert.ToInt32(Console.ReadLine());

if (week == 6 || week == 7) Console.WriteLine("Да");
else Console.WriteLine("Нет");