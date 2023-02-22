// Задача 25: Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Numbers(string message)
{
Console.Write(message);
double result = Convert.ToDouble(Console.ReadLine());
return result;
}
double number = Numbers("Введите число: ");
double degree = Numbers("Введите степень: ");

double end = Math.Pow(number, degree);
Console.WriteLine($"Получилось- {end}");


