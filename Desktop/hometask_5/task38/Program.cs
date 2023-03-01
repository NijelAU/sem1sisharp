// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
//  максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// RunIntNDoubleRandoms

System.Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[] array = new double[n];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
array[i] = Math.Round(rand.Next(1, 100) + rand.NextDouble(), 4);
System.Console.WriteLine($"Это массив [{string.Join(", ", array)}]");

double maxNumber = 0;
double minNumber = 0;

for (int i = 0; i < array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
  {
    if (array[i] > array[j])
    {
    maxNumber = array[i];
    array[i] = array[j];
    array[j] = maxNumber;
    }
  }
}

for (int i = 0; i < array.Length; i++)
{
 for (int q = i + 1; q < array.Length; q++)
{
    if (array[i] < array[q])
{
    minNumber = array [i];
    array[i] = array[q];
    array[q] = minNumber; 
}
  }
}
System.Console.WriteLine($"Это максимальное число массива - {maxNumber}");
System.Console.WriteLine($"Это минимальное число массива - {minNumber}");

double result =  Math.Round((maxNumber - minNumber),4);
System.Console.WriteLine($"А это разница между максимальным и минимальным числом - {result}");