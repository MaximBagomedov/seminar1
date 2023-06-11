/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Write("Введите первое число: ");

int number = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = Convert.ToInt16(Console.ReadLine());
if (number > number_2)
    Console.WriteLine($"максимальное число : {number}, а минимальное: {number_2}");
else
    Console.WriteLine($"максимальное число : {number_2}, а минимальное: {number}");

