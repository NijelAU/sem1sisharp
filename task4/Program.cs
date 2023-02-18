// Алексей Свищев: Напишите программу, которая 
//принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да
int number = new Random().Next(10, 100);
Console.WriteLine($"Ваше случайное число: {number}");
if (number % 7 == 0 && number%23 == 0)
{
 Console.WriteLine("ДА");   
}
else 
{
    Console.WriteLine("Нет");
}