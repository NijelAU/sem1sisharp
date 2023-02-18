// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1 || number == 2 || number == 3 || number == 4 ||  number == 5)
{
Console.WriteLine("Это будни");
}
else if (number <= 0 || number > 8)
{
    Console.WriteLine("Я знаю только 7 дней, ты из бдущеего?");
}
else
{
    Console.WriteLine("Отдыхай братишка!");
}