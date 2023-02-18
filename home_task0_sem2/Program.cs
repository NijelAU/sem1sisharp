// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число - ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 1001) 
{
    Console.WriteLine("Трехзначное это когда три цифры");
}

else
{
    int mod = number%10;
    int mod2 = number/100;
    int mod3 = (number - mod2 * 100 - mod)/10;
    Console.WriteLine($"{mod3}");
}