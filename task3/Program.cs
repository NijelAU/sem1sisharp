// Напишите программу, которая принимает на вход два числа
//  и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
Console.WriteLine("Введите 1 число - ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 1 число - ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number == number2 * number2 || number2 == number * number)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}