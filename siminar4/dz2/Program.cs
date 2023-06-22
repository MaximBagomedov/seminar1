// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Number(int number)
{
    
    int counter = Convert.ToString(number).Length;
    int ostatok = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      ostatok = number - number % 10;
      result = result + (number - ostatok);
      number = number / 10;
    }
   return result;
}
int summa = Number(number);
Console.WriteLine(summa);  