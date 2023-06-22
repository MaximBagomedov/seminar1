// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// одномерные с Рандомом
/*int []array = new int [8];
Random random = new Random ();
for (int i = 0; i < array.Length; i++) 
{
    array[i] = random.Next (0, 255);
    Console.Write($"{array[i]}, ");
}*/
int []array = {1, 2, 5, 7, 19, 20, int.MaxValue, int.MinValue};
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.Write("]");