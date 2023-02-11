Console.WriteLine("Введите 1 число - ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число - ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write($"{number1} больше {number2} меньше");
}
else if (number1 == number2)
{
    Console.Write("Цифры равны");
}
else
{
    Console.Write($"{number2} больше {number1} меньше");
}