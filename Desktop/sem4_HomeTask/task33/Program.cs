//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да 

int[] FillArrayWithRandomNumbers(int length)
{
int[] arr = new int [length];
Random rnd = new Random();
for(int i =0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);

Console.WriteLine($"[ {string.Join(", ", array)} ]");

System.Console.WriteLine("Введите цифру поиска: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (array.Any(str => str == number1))
{
    Console.WriteLine(string.Format("Цифра '{0}' содержится в массиве", number1));

}
else
{
    Console.WriteLine("Цифра не содержится в массиве");
}