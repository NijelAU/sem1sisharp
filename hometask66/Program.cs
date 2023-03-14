// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в 
//промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumNumbers(int A, int B)
{
    if (B < A)
    {
        return 0;
   }
   return B + SumNumbers(A, B-1);
}

Console.Write("Введите число от ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число до ");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма от {A} до {B} = {SumNumbers(A,B)}");