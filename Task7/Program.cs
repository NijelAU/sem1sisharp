//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6

Console.Write("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int LastNumder = 0;
if (N > 99 && N < 1000)
{
 LastNumder = N%10;
 Console.Write(LastNumder);
}
else
{
    Console.Write("Некоректный ввод");
}