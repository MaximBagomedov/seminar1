/*  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.Write("Введите первое число: ");
int number = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите третье число: ");
int number_3 = Convert.ToInt16(Console.ReadLine());
int max = number;
if (number_2 > number)
{
    max = number_2;
}
if (number_3 > max)
{
    max = number_3;
}
Console.WriteLine($"Максимальное число трех чисел: {max}");