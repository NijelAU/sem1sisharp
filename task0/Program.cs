// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
// на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("ВВедите число ");
int number = Convert.ToInt32(Console.ReadLine());
int square = 0;
square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");