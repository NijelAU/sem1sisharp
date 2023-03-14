﻿// Задача 65: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, "

void RoudToN(int max, int min)
{
    if (max < min)
    {
        return;
    }
    RoudToN(max-1 , min);
    System.Console.Write($"{max} ");
}

Console.Write("Введите число Максимальное ");
int numberMax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Минимальное ");
int numberMin = Convert.ToInt32(Console.ReadLine());
RoudToN(max:numberMax,min:numberMin);