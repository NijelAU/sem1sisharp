// Напишите программу , которая выводит случайное число из отрезка 
// [10, 99] и показывает наибольшою цифру числа
// Например
// 78 - > 8
// 12->2
// 85 ->8

int number = new Random().Next(10, 100);
Console.WriteLine($"Ваше случайное число: {number}");

int digit = number/10;
int digit2 = number%10;

if (digit > digit2)
{
    Console.Write($"<Больше цифра числа: {digit}");
}
else
{
    Console.WriteLine($"Найбольше цифра числа {digit2} ");
}