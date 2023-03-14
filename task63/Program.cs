// Задача 63: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// // N = 6 -> "1, 2, 3, 4, 5
void RoudToN(int N)
{
    if (N == 0)
    {
        return;
    }
    RoudToN(N-1);
    System.Console.Write($"{N} ");
}


System.Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
RoudToN(N);