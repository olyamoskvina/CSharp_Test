// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int sqrt = Convert.ToInt32(Math.Pow(a, 2));
if(b == sqrt)
{
    Console.Write("второе число является квадратом первого");
}
else
{
    Console.Write("второе число НЕ является квадратом первого");
}
