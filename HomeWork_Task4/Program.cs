Console.WriteLine("Введите 1 число - ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число - ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число - ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1>number2 && number1>number3)
{
    Console.Write($"Максимальное число {number1} ");
}
else if (number2>number1 && number2>number3)
{
    Console.Write($"Максимальное число {number2} ");
}
else 
{
    Console.Write($"Максимальное число {number3} ");
}