// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = GetSecond(num);

int GetSecond(int num)
{
    int first = num % 100;
    int second = first / 10;
    return second;
}    

Console.WriteLine($"{num} -> {result}");