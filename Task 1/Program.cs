// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите произвольное целое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральную степень для этого числа: ");
int b = int.Parse(Console.ReadLine()!);
int naturalDegree = a;

for (int i=1; i<b; i++)
{
  naturalDegree = naturalDegree * a;
}

Console.Write($"Натуральная степень числа {a}^{b} = {naturalDegree} | ");
