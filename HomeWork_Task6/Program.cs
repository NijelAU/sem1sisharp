Console.WriteLine("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());
int N = number%2;
//Console.WriteLine($"{N}");
if (N == 0)
{
   Console.WriteLine("Да");
}
else
{
    Console.WriteLine($"Неа");
}