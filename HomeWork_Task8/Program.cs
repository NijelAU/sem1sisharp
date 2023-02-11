Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = N%2;
while(temp <= N)
{
    Console.Write($"{temp} ");
    temp = temp +2;
}