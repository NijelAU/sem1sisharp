// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
// Мое самостоятельное решение
Console.WriteLine("Введите число сравнения- ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число - ");
int number2 = Convert.ToInt32(Console.ReadLine());
int square = 0;
square = number2 * number2;

if (number1 == square)
{
    Console.WriteLine("ya, baby");
}
else
{
    Console.WriteLine("NOOo, baby");
}

//Правильное решение
//Console.WriteLine("Введите число сравнения- ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число - ");
//int number2 = Convert.ToInt32(Console.ReadLine());
//if (number1 == number2*number2)
//{
//    Console.WriteLine("ДА");
//}
//else
//{
//    Console.WriteLine("Нет");
//}